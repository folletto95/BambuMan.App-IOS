using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using BambuMan.Interfaces;
using BambuMan.Shared;
using BambuMan.Shared.Interfaces;
using BambuMan.Shared.Nfc;
using BambuMan.UI.Settings;
using CommunityToolkit.Maui.Core.Platform;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SpoolMan.Api.Model;
using LogLevel = BambuMan.Shared.Enums.LogLevel;

namespace BambuMan.UI.Main
{
    public partial class MainPage
    {
        private readonly MainPageViewModel viewModel;

        private readonly SpoolmanManager spoolmanManager;
        private readonly ILogger<MainPage> logger;
        private readonly IToneGenerator? toneGenerator;
        private readonly IInvokeIndent invokeIndent;
        private Spool? currentSpool;
        private BambuFillamentInfo? currentBambuFillamentInfo;

        public MainPage(MainPageViewModel viewModel, SpoolmanManager spoolmanManager, ILogger<MainPage> logger, IToneGenerator toneGenerator, IInvokeIndent invokeIndent)
        {
            InitializeComponent();

            this.spoolmanManager = spoolmanManager;
            this.logger = logger;
            this.toneGenerator = toneGenerator;
            this.invokeIndent = invokeIndent;
            this.viewModel = viewModel;
            BindingContext = viewModel;

            spoolmanManager.AppVersion = BuildVersionModel.CurrentBuildVersion;
            spoolmanManager.ShowLogs = true;
            spoolmanManager.ApiUrl = Preferences.Default.Get(SettingsPage.KeySpoolmanUrl, string.Empty);

            spoolmanManager.OnStatusChanged += SpoolmanManagerOnStatusChanged;
            spoolmanManager.OnLogMessage += SpoolmanManagerOnLogMessage;
            spoolmanManager.OnShowMessage += SpoolmanManagerOnShowMessage;
            spoolmanManager.OnSpoolFound += SpoolmanManagerOnSpoolFound;
            spoolmanManager.OnPlayErrorTone += SpoolmanManagerOnPlayErrorTone;
        }
        
        private async void SpoolmanManagerOnPlayErrorTone()
        {
            try
            {
                if (toneGenerator != null) await toneGenerator.PlayAlarmTone();
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error in SpoolmanManagerOnPlayErrorTone");
            }
        }

        private async void SpoolmanManagerOnSpoolFound(Spool spool, BambuFillamentInfo info)
        {
            try
            {
                viewModel.InventorySpool(spool, info);
                
                currentSpool = spool;
                currentBambuFillamentInfo = info;

                viewModel.ShowSpool(spool);

                TfSpoolWeight.Focus();
                TfSpoolWeight.SelectAllText();

                await TfSpoolWeight.EntryView.ShowKeyboardAsync(CancellationToken.None);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error in SpoolmanManagerOnSpoolFound");
            }
        }

        private async void SpoolmanManagerOnShowMessage(bool isError, string message)
        {
            try
            {
                await viewModel.ClearMessages();

                if (isError) await viewModel.ShowErrorMessage(message);
                else await viewModel.ShowSuccessMessage(message);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error in SpoolmanManagerOnLogMessage");
            }
        }

        private async void SpoolmanManagerOnLogMessage(LogLevel level, string message)
        {
            try
            {
                await viewModel.AddLog(level, message);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error in SpoolmanManagerOnLogMessage");
            }
        }

        private async void SpoolmanManagerOnStatusChanged()
        {
            try
            {
                await viewModel.Validate(spoolmanManager);
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error in SpoolmanManagerOnStatusChanged");
            }
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();

                //viewModel.Logs.Clear();
                await viewModel.Validate(spoolmanManager);

                spoolmanManager.ApiUrl = Preferences.Default.Get(SettingsPage.KeySpoolmanUrl, string.Empty);

                await spoolmanManager.Init();

                // In order to support Mifare Classic 1K tags (read/write), you must set legacy mode to true.
                CrossNfc.Legacy = false;

                if (CrossNfc.IsSupported)
                {
                    viewModel.NfcIsEnabled = CrossNfc.Current.IsEnabled;
                    viewModel.NfcText = CrossNfc.Current.IsEnabled ? "NFC ENABLED" : "NFC DISABLED";

                    if (DeviceInfo.Platform == DevicePlatform.iOS) viewModel.IsDeviceOs = true;

                    await AutoStartAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error in OnAppearing");
            }
        }

        protected override bool OnBackButtonPressed()
        {
            Task.Run(StopListening);
            return base.OnBackButtonPressed();
        }

        #region Helpers

        /// <summary>
        /// Write a debug message in the debug console
        /// </summary>
        /// <param name="message">The message to be displayed</param>
        private void Debug(string message) => System.Diagnostics.Debug.WriteLine(message);

        /// <summary>
        /// Display an alert
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        /// <param name="title">Alert title</param>
        /// <returns>The task to be performed</returns>
        private Task ShowAlert(string message, string? title = null) => DisplayAlert(string.IsNullOrWhiteSpace(title) ? "NFC" : title, message, "OK");


        #endregion

        #region Nfc Logic

        /// <summary>
        /// Task to start listening for NFC tags if the user's device platform is not iOS
        /// </summary>
        /// <returns>The task to be performed</returns>
        private async Task StartListeningIfNotiOs()
        {
            if (viewModel.IsDeviceOs)
            {
                SubscribeEvents();
                return;
            }

            await BeginListening();
        }

        /// <summary>
        /// Task to safely start listening for NFC Tags
        /// </summary>
        /// <returns>The task to be performed</returns>
        private async Task BeginListening()
        {
            try
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    SubscribeEvents();
                    CrossNfc.Current.StartListening();
                });
            }
            catch (Exception ex)
            {
                await ShowAlert(ex.Message);
            }
        }

        /// <summary>
        /// Task to safely stop listening for NFC tags
        /// </summary>
        /// <returns>The task to be performed</returns>
        private async Task StopListening()
        {
            try
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    CrossNfc.Current.StopListening();
                    UnsubscribeEvents();
                });
            }
            catch (Exception ex)
            {
                await ShowAlert(ex.Message);
            }
        }


        /// <summary>
        /// Auto Start Listening
        /// </summary>
        /// <returns></returns>
        private async Task AutoStartAsync()
        {
            // Some delay to prevent Java.Lang.IllegalStateException "Foreground dispatch can only be enabled when your activity is resumed" on Android
            await Task.Delay(500);
            await StartListeningIfNotiOs();
        }

        /// <summary>
        /// Subscribe to the NFC events
        /// </summary>
        private void SubscribeEvents()
        {
            if (viewModel.EventsAlreadySubscribed) UnsubscribeEvents();

            viewModel.EventsAlreadySubscribed = true;

            CrossNfc.Current.OnMessageReceived += Current_OnMessageReceived;
            CrossNfc.Current.OnNfcStatusChanged += Current_OnNfcStatusChanged;
            CrossNfc.Current.OnTagListeningStatusChanged += Current_OnTagListeningStatusChanged;
            CrossNfc.Current.OnTagIntentReceived += Current_OnTagIntentReceived;
            
            if (viewModel.IsDeviceOs) CrossNfc.Current.OnIOsReadingSessionCancelled += Current_OniOSReadingSessionCancelled;
        }

        /// <summary>
        /// Unsubscribe from the NFC events
        /// </summary>
        private void UnsubscribeEvents()
        {
            CrossNfc.Current.OnMessageReceived -= Current_OnMessageReceived;
            CrossNfc.Current.OnNfcStatusChanged -= Current_OnNfcStatusChanged;
            CrossNfc.Current.OnTagListeningStatusChanged -= Current_OnTagListeningStatusChanged;
            CrossNfc.Current.OnTagIntentReceived -= Current_OnTagIntentReceived;

            if (viewModel.IsDeviceOs) CrossNfc.Current.OnIOsReadingSessionCancelled -= Current_OniOSReadingSessionCancelled;

            viewModel.EventsAlreadySubscribed = false;
        }

        private void Current_OnTagIntentReceived(object? sender, EventArgs e)
        {
            CloseButton_OnClicked(sender, e);
        }

        /// <summary>
        /// Event raised when Listener Status has changed
        /// </summary>
        /// <param name="isListening"></param>
        private void Current_OnTagListeningStatusChanged(bool isListening) => viewModel.DeviceIsListening = isListening;

        /// <summary>
        /// Event raised when NFC Status has changed
        /// </summary>
        /// <param name="isEnabled">NFC status</param>
        private void Current_OnNfcStatusChanged(bool isEnabled)
        {
            viewModel.NfcIsEnabled = isEnabled;
            viewModel.NfcText = isEnabled ? "NFC ENABLED" : "NFC DISABLED";
        }

        /// <summary>
        /// Event raised when a NDEF message is received
        /// </summary>
        /// <param name="tagInfo">Received <see cref="ITagInfo"/></param>
        private async void Current_OnMessageReceived(ITagInfo? tagInfo)
        {
            try
            {
                if (tagInfo == null)
                {
                    await ShowAlert("No tag found");
                    return;
                }

                // Customized serial number
                var identifier = tagInfo.Identifier;
                var serialNumber = NfcUtils.ByteArrayToHexString(identifier, ":");
                var title = !string.IsNullOrWhiteSpace(serialNumber) ? $"Tag [{serialNumber}]" : "Tag Info";

                if (tagInfo is BambuFillamentInfo bambuFillamentInfo)
                {
                    var json = JsonConvert.SerializeObject(bambuFillamentInfo, Formatting.Indented);
                    await viewModel.AddLog(LogLevel.Information, json);

                    var buyDate = DateTime.TryParse(Preferences.Default.Get(SettingsPage.KeyDefaultBuyDate, string.Empty), CultureInfo.CurrentCulture, out var resultDate) ? (DateTime?)resultDate : null;
                    var defaultPrice = decimal.TryParse(Preferences.Default.Get(SettingsPage.KeyDefaultPrice, string.Empty), NumberStyles.Any, NumberFormatInfo.CurrentInfo, out var result) ? (decimal?)result : null;
                    var defaultLotNr = Preferences.Default.Get(SettingsPage.KeyDefaultLotNr, string.Empty);
                    var defaultLocation = Preferences.Default.Get(SettingsPage.KeyDefaultLocation, string.Empty);

                    await viewModel.ClearMessages();
                    await spoolmanManager.InventorySpool(bambuFillamentInfo, buyDate, defaultPrice, defaultLotNr, defaultLocation);
                    return;
                }

                if (!tagInfo.IsSupported)
                {
                    await viewModel.ShowErrorMessage("Error reading tag, please try again!");
                    if (toneGenerator != null) await toneGenerator.PlayAlarmTone();
                }
                else if (tagInfo.IsEmpty)
                {
                    await viewModel.ShowErrorMessage("Empty tag");
                }
                else if (tagInfo.Records is { Length: > 0 })
                {
                    var first = tagInfo.Records.FirstOrDefault(x => x != null);
                    if (first != null) await ShowAlert(GetMessage(first), title);
                }
            }
            catch (Exception e)
            {
                logger.LogError(e, "Error in Current_OnMessageReceived");
            }
        }

        /// <summary>
        /// Event raised when user cancelled NFC session on iOS 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Current_OniOSReadingSessionCancelled(object? sender, EventArgs e) => Debug("iOS NFC Session has been cancelled");

        /// <summary>
        /// Returns the tag information from NDEF record
        /// </summary>
        /// <param name="record"><see cref="NfcNdefRecord"/></param>
        /// <returns>The tag information</returns>
        private string GetMessage(NfcNdefRecord record)
        {
            var message = $"Message: {record.Message}";
            message += Environment.NewLine;
            message += $"RawMessage: {Encoding.UTF8.GetString(record.Payload ?? [])}";
            message += Environment.NewLine;
            message += $"Type: {record.TypeFormat}";

            if (string.IsNullOrWhiteSpace(record.MimeType)) return message;

            message += Environment.NewLine;
            message += $"MimeType: {record.MimeType}";

            return message;
        }

        #endregion

        #region Test Stuff

        [SuppressMessage("ReSharper", "StringLiteralTypo")]
        private async void Button_OnClicked(object? sender, EventArgs e)
        {
            try
            {
                var json = "{\"SerialNumber\":\"2A97DC73\",\"TagManufacturerData\":\"EggEAAQTc6BRVeCQ\",\"MaterialVariantIdentifier\":\"A01-B3\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"0078BFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"780B2E7DE43C4557A43A9EBA81ACD240\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-08-03T17:09:00\",\"ProductionDateTimeShort\":\"A2408030045\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\"}";
                var bambuFillamentInfo = JsonConvert.DeserializeObject<BambuFillamentInfo>(json);

                json = JsonConvert.SerializeObject(bambuFillamentInfo, Formatting.Indented);
                await viewModel.AddLog(LogLevel.Information, json);

                var buyDate = DateTime.TryParse(Preferences.Default.Get(SettingsPage.KeyDefaultBuyDate, string.Empty), CultureInfo.CurrentCulture, out var resultDate) ? (DateTime?)resultDate : null;
                var defaultPrice = decimal.TryParse(Preferences.Default.Get(SettingsPage.KeyDefaultPrice, string.Empty), NumberStyles.Any, NumberFormatInfo.CurrentInfo, out var result) ? (decimal?)result : null;
                var defaultLotNr = Preferences.Default.Get(SettingsPage.KeyDefaultLotNr, string.Empty);
                var defaultLocation = Preferences.Default.Get(SettingsPage.KeyDefaultLocation, string.Empty);

                await viewModel.ClearMessages();
                await spoolmanManager.InventorySpool(bambuFillamentInfo!, buyDate, defaultPrice, defaultLotNr, defaultLocation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error on Test button click");
            }
        }

        private async void CloseButton_OnClicked(object? sender, EventArgs e)
        {
            try
            {
                await TfSpoolWeight.EntryView.HideKeyboardAsync(CancellationToken.None);

                viewModel.ShowSpoolEdit = false;
                currentSpool = null;
                currentBambuFillamentInfo = null;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error in CloseButton_OnClicked");
            }
        }

        private void ClearLogs_OnClicked(object? sender, EventArgs e)
        {
            viewModel.Logs.Clear();
        }

        private void ClearInventory_OnClicked(object? sender, EventArgs e)
        {
            viewModel.HasInventoryItems = false;
            viewModel.Inventory.Clear();
        }

        private async void EmailLogs_OnClicked(object? sender, EventArgs e)
        {
            try
            {
                var logs = $"{string.Join("\r\n", viewModel.Logs.Select(x => x.Content))}\r\n\r\n";
                await invokeIndent.SendEmail("bambuman.app@gmail.com", "Bambu logs", logs);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error in EmailLogs_OnClicked");
            }
        }

        #endregion

        private async void SaveChanges_OnClicked(object? sender, EventArgs e)
        {
            try
            {
                await viewModel.ClearMessages();

                FormView.Submit();

                if (!FormView.IsValidated || currentSpool == null) return;

                await TfSpoolWeight.EntryView.HideKeyboardAsync(CancellationToken.None);

                await spoolmanManager.UpdateSpool(
                    currentSpool,
                    viewModel.SpoolBuyDate,
                    viewModel.SpoolPrice,
                    viewModel.SpoolLotNr,
                    viewModel.SpoolLocation,
                    viewModel.SpoolEmptyWeight.GetValueOrDefault(),
                    viewModel.SpoolInitialWeight.GetValueOrDefault(),
                    viewModel.SpoolWeight.GetValueOrDefault(),
                    currentBambuFillamentInfo?.TrayUid,
                    currentBambuFillamentInfo?.ProductionDateTime);

                viewModel.ShowSpoolEdit = false;
                currentSpool = null;
                currentBambuFillamentInfo = null;
            }
            catch (Exception ex)
            {
                await viewModel.AddLog(LogLevel.Error, "Error on save changes. " + e);
                logger.LogError(ex, "Error on spool save changes");
            }
        }
    }
}
