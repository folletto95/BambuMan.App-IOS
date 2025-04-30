using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using BambuMan.Shared;
using BambuMan.Shared.Enums;
using Microsoft.Win32;
using Newtonsoft.Json;
using SpoolMan.Api.Model;
using LogLevel = BambuMan.Shared.Enums.LogLevel;

namespace BambuMan.Desktop;

public partial class MainForm : Form
{
    private const string RegSubKey = "BambuMan";
    private const string RegKeyShowApduCommands = "ShowApduCommands";
    private const string RegKeyShowLogsNfcLogs = "ShowLogsNfcLogs";
    private const string RegKeyWriteJsonFiles = "WriteJsonFiles";
    private const string RegKeyLogSpoolmanApi = "LogSpoolmanApi";
    private const string RegKeySpoolmanUrl = "SpoolmanUrl";

    private const string RegKeyPrice = "Price";
    private const string RegKeyLocation = "Location";

    private readonly NfcReader? nfcReader;
    private readonly SpoolmanManager? spoolmanManager;
    private Spool? currentSpool;
    private BambuFillamentInfo? currentBambuFillamentInfo;

    public MainForm()
    {
        InitializeComponent();

#if !DEBUG
        testTagToolStripMenuItem.Visible = false;
#endif

        showADBCommandsToolStripMenuItem.Checked = GetRegistryValue(RegKeyShowApduCommands, false);
        showNfcLogsToolStripMenuItem.Checked = GetRegistryValue(RegKeyShowLogsNfcLogs, false);
        writeJsonFilesOnReadToolStripMenuItem.Checked = GetRegistryValue(RegKeyWriteJsonFiles, false);
        logSpoolmanApiToolStripMenuItem.Checked = GetRegistryValue(RegKeyLogSpoolmanApi, false);
        txtSpoolmanUrl.Text = GetRegistryValue(RegKeySpoolmanUrl, string.Empty);
        nudPrice.Value = GetRegistryValue(RegKeyPrice, 12.0m);
        txtLocation.Text = GetRegistryValue(RegKeyLocation, string.Empty);

        nfcReader = new NfcReader
        {
            ShowLogs = showNfcLogsToolStripMenuItem.Checked,
            ShowApduCommands = showADBCommandsToolStripMenuItem.Checked,
            WriteJsonFiles = writeJsonFilesOnReadToolStripMenuItem.Checked
        };

        nfcReader.OnLogMessage += NfcReaderOnOnLogMessage;
        nfcReader.OnSpoolFound += NfcReaderOnOnSpoolFound;

        nfcReader.Start();

        spoolmanManager = new SpoolmanManager(null)
        {
            ShowLogs = logSpoolmanApiToolStripMenuItem.Checked,
            ApiUrl = txtSpoolmanUrl.Text,
        };

        spoolmanManager.OnStatusChanged += SpoolmanManagerOnStatusChanged;
        spoolmanManager.OnLogMessage += SpoolmanManagerOnLogMessage;
        spoolmanManager.OnSpoolFound += SpoolmanManagerOnSpoolFound;
    }

    protected override async void OnLoad(EventArgs e)
    {
        try
        {
            base.OnLoad(e);
            if (spoolmanManager != null) await spoolmanManager.Init();
        }
        catch (Exception ex)
        {
            AppendText(LogLevel.Error, ex.ToString());
        }
    }

    #region Events

    private async void NfcReaderOnOnSpoolFound(BambuFillamentInfo info)
    {
        try
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate { NfcReaderOnOnSpoolFound(info); }));
                return;
            }

            var json = JsonConvert.SerializeObject(info, Formatting.Indented);
            AppendText(LogLevel.Information, json);

            if (spoolmanManager != null) await spoolmanManager.InventorySpool(info, dtpBuyDate.Value, nudPrice.Value, txtLotNr.Text, txtLocation.Text);
        }
        catch (Exception ex)
        {
            AppendText(LogLevel.Error, ex.ToString());
        }
    }

    private void NfcReaderOnOnLogMessage(LogLevel level, string message)
    {
        if (InvokeRequired)
        {
            BeginInvoke(new MethodInvoker(delegate { NfcReaderOnOnLogMessage(level, message); }));
            return;
        }

        AppendText(level, message);
    }

    private void SpoolmanManagerOnLogMessage(LogLevel level, string message)
    {
        if (InvokeRequired)
        {
            BeginInvoke(new MethodInvoker(delegate { SpoolmanManagerOnLogMessage(level, message); }));
            return;
        }

        AppendText(level, message);
    }

    private void SpoolmanManagerOnSpoolFound(Spool spool, BambuFillamentInfo info)
    {
        if (InvokeRequired)
        {
            BeginInvoke(new MethodInvoker(delegate { SpoolmanManagerOnSpoolFound(spool, info); }));
            return;
        }

        nudEmptyWeight.Value = spool.SpoolWeight ?? spool.Filament.SpoolWeight ?? spool.Filament.Vendor?.EmptySpoolWeight ?? 0;
        nudInitialWeight.Value = spool.InitialWeight ?? spool.Filament.Weight ?? 0;
        nudSpoolWeight.Value = Math.Max(0, nudEmptyWeight.Value + nudInitialWeight.Value - spool.UsedWeight);
        nudSpoolPrice.Value = spool.Price ?? spool.Filament.Price ?? 0;
        txtLotNr.Text = spool.LotNr;
        txtSpoolLocation.Text = spool.Location;
        dtpSpoolBuyDate.Value = spool.Extra.TryGetValue("buy_date", out var buyDate) ? DateTime.Parse(buyDate.Replace("\"", "")) : DateTime.Today;

        gbSpoolInfo.Enabled = true;

        nudSpoolWeight.Focus();
        nudSpoolWeight.Select(0, 40);

        currentSpool = spool;
        currentBambuFillamentInfo = info;
    }

    private void SpoolmanManagerOnStatusChanged()
    {
        if (InvokeRequired)
        {
            BeginInvoke(new MethodInvoker(SpoolmanManagerOnStatusChanged));
            return;
        }

        tsslStatus.Text = (spoolmanManager?.Status ?? SpoolmanManagerStatusType.Initializing).GetDescriptionAttr();
    }


    #endregion
    
    #region Registry read and write

    private TClass? GetRegistryValue<TClass>(string key, TClass? defaultValue)
    {
        if (!OperatingSystem.IsWindows()) return defaultValue;

        var baseKey = Registry.CurrentUser;

        using var software = baseKey.OpenSubKey("Software", true) ?? baseKey.CreateSubKey("Software");
        using var subKey = software.OpenSubKey(RegSubKey, true) ?? software.CreateSubKey(RegSubKey);

        if (defaultValue is bool boolValue) return (TClass)(object)(subKey.GetValue(key, boolValue).ToString() == "True");
        if (defaultValue is decimal decimalValue) return (TClass)(object)(decimal.TryParse(subKey.GetValue(key, decimalValue).ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out var result) ? result : defaultValue);

        return (TClass?)subKey.GetValue(key, defaultValue);
    }

    private TClass SetRegistryValue<TClass>(string key, TClass value)
    {
        if (!OperatingSystem.IsWindows()) return value;

        var baseKey = Registry.CurrentUser;

        using var software = baseKey.OpenSubKey("Software", true) ?? baseKey.CreateSubKey("Software");
        using var subKey = software.OpenSubKey(RegSubKey, true) ?? software.CreateSubKey(RegSubKey);

        subKey.SetValue(key, value ?? throw new ArgumentNullException(nameof(value)));

        return value;
    }

    #endregion

    #region UI Events

    private void showADBCommandsToolStripMenuItem_CheckStateChanged(object? sender, EventArgs e)
    {
        var value = SetRegistryValue(RegKeyShowApduCommands, showADBCommandsToolStripMenuItem.Checked);
        if (nfcReader != null) nfcReader.ShowApduCommands = value;
    }

    private void showNfcLogsToolStripMenuItem_CheckStateChanged(object? sender, EventArgs e)
    {
        var value = SetRegistryValue(RegKeyShowLogsNfcLogs, showNfcLogsToolStripMenuItem.Checked);
        if (nfcReader != null) nfcReader.ShowLogs = value;
    }

    private void writeJsonFilesOnReadToolStripMenuItem_CheckStateChanged(object? sender, EventArgs e)
    {
        var value = SetRegistryValue(RegKeyWriteJsonFiles, writeJsonFilesOnReadToolStripMenuItem.Checked);
        if (nfcReader != null) nfcReader.WriteJsonFiles = value;
    }

    private void logSpoolmanApiToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
    {
        var value = SetRegistryValue(RegKeyLogSpoolmanApi, logSpoolmanApiToolStripMenuItem.Checked);
        if (spoolmanManager != null) spoolmanManager.ShowLogs = value;
    }

    private void nudPrice_ValueChanged(object sender, EventArgs e)
    {
        SetRegistryValue(RegKeyPrice, nudPrice.Value);
    }

    private void txtLocation_TextChanged(object sender, EventArgs e)
    {
        SetRegistryValue(RegKeyLocation, txtLocation.Text);
    }

    private async void btnSetUrl_Click(object sender, EventArgs e)
    {
        try
        {
            SetRegistryValue(RegKeySpoolmanUrl, txtSpoolmanUrl.Text);

            if (spoolmanManager == null) return;

            spoolmanManager.ApiUrl = txtSpoolmanUrl.Text;
            await spoolmanManager.Init();
        }
        catch (Exception ex)
        {
            AppendText(LogLevel.Error, ex.ToString());
        }
    }

    private void clearLogsToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        lock (rtbLogs)
        {
            rtbLogs.Clear();
        }
    }

    private async void updateSpool_Click(object sender, EventArgs e)
    {
        try
        {
            if (spoolmanManager == null || currentSpool == null) return;

            await spoolmanManager.UpdateSpool(
                currentSpool,
                dtpBuyDate.Value,
                nudSpoolPrice.Value,
                txtLotNr.Text,
                txtLocation.Text,
                nudEmptyWeight.Value,
                nudInitialWeight.Value,
                nudSpoolWeight.Value,
                currentBambuFillamentInfo?.TrayUid,
                currentBambuFillamentInfo?.ProductionDateTime);

            gbSpoolInfo.Enabled = false;
        }
        catch (Exception ex)
        {
            AppendText(LogLevel.Error, ex.ToString());
        }
    }

    private void nudSpoolWeight_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;
        updateSpool_Click(this, EventArgs.Empty);
    }

    private void eXitToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        Application.Exit();
    }

    #endregion

    #region Helpers

    public void AppendText(LogLevel level, string text)
    {
        lock (rtbLogs)
        {
            var color = level switch
            {
                LogLevel.None or LogLevel.Trace or LogLevel.Debug => Color.DimGray,
                LogLevel.Information => Color.Black,
                LogLevel.Success => Color.DarkGreen,
                LogLevel.Warning => Color.DarkOrange,
                LogLevel.Error or LogLevel.Critical => Color.Maroon,
                _ => throw new ArgumentOutOfRangeException(nameof(level), level, null)
            };

            rtbLogs.SuspendLayout();
            rtbLogs.SelectionColor = color;
            rtbLogs.AppendText($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]: {text}\r\n");
            rtbLogs.ScrollToCaret();
            rtbLogs.ResumeLayout();
        }
    }

    #endregion

    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    private async void testTagToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //var json = "{\"SerialNumber\":\"4A5EAD3B\",\"TagManufacturerData\":\"gggEAAStJvpSS1SQ\",\"MaterialVariantIdentifier\":\"A00-M0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"9CDBD9FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBPQB+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"FEE8B504E67B4147A855166BE75D9E6C\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-04-02T15:21:00\",\"ProductionDateTimeShort\":\"24_04_02_15\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"FFFFFFFF\"}";
        var json = "{\"SerialNumber\":\"93578239\",\"TagManufacturerData\":\"fwgEAAQmwd2CnueQ\",\"MaterialVariantIdentifier\":\"S05-C0\",\"UniqueMaterialIdentifier\":\"FS05\",\"FilamentType\":\"PLA-S\",\"DetailedFilamentType\":\"Support for PLA\",\"Color\":\"00000000\",\"SpoolWeight\":250,\"FilamentDiameter\":1.75,\"DryingTemperature\":70,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":220,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"pDikOIQD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"27E9707326574178BFFACF9004A81DEB\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-01-04T08:53:00\",\"ProductionDateTimeShort\":\"20250104\",\"FilamentLength\":87,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"S05-C0-1.75-250\"}";

        var bambuFillamentInfo = JsonConvert.DeserializeObject<BambuFillamentInfo>(json);

        json = JsonConvert.SerializeObject(bambuFillamentInfo, Formatting.Indented);
        AppendText(LogLevel.Information, json);

        if(spoolmanManager != null) await spoolmanManager.InventorySpool(bambuFillamentInfo!, DateTime.Today, 12, string.Empty, string.Empty);
    }
}