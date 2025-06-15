using System.Globalization;
using BambuMan.UI.Scan;
using Microsoft.Extensions.Logging;

namespace BambuMan.UI.Settings;

public partial class SettingsPage
{
    public const string KeySpoolmanUrl = "spoolman_url";
    public const string KeyDefaultBuyDate = "default_buy_date";
    public const string KeyDefaultPrice = "default_price";
    public const string KeyDefaultLotNr = "default_lot_nr";
    public const string KeyDefaultLocation = "default_location";

    private readonly SettingsPageViewModel viewModel;
    private readonly ILogger<SettingsPage> logger;

    public SettingsPage(SettingsPageViewModel viewModel, ILogger<SettingsPage> logger)
    {
        InitializeComponent();
        
        this.viewModel = viewModel;
        this.logger = logger;
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        viewModel.SpoolmanUrl = Preferences.Default.Get(KeySpoolmanUrl, string.Empty);
        viewModel.BuyDate = DateTime.TryParse(Preferences.Default.Get(KeyDefaultBuyDate, string.Empty), CultureInfo.CurrentCulture, out var resultDate) ? resultDate : null;
        viewModel.DefaultPrice = decimal.TryParse(Preferences.Default.Get(KeyDefaultPrice, string.Empty), NumberStyles.Any, NumberFormatInfo.CurrentInfo, out var result) ? result : null;
        viewModel.DefaultLotNr = Preferences.Default.Get(KeyDefaultLotNr, string.Empty);
        viewModel.DefaultLocation = Preferences.Default.Get(KeyDefaultLocation, string.Empty);
    }

    private async void ImageButton_OnClicked(object? sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync(nameof(ScanPage));
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error navigating to qrcode scanner");
        }
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        if (TfSpoolmanUrl.IsValid) Preferences.Default.Set(KeySpoolmanUrl, viewModel.SpoolmanUrl);

        if (TfBuyDate.IsValid)
        {
            if (TfBuyDate.Date == null || viewModel.BuyDate == null) Preferences.Default.Remove(KeyDefaultBuyDate);
            else Preferences.Default.Set(KeyDefaultBuyDate, $"{viewModel.BuyDate:yyyy-MM-dd}");
        }

        if (TfPrice.IsValid)
        {
            if (TfPrice.Text == string.Empty || viewModel.DefaultPrice == null) Preferences.Default.Remove(KeyDefaultPrice);
            else Preferences.Default.Set(KeyDefaultPrice, $"{viewModel.DefaultPrice:0.00}");
        }

        if (TfLotNr.IsValid) Preferences.Default.Set(KeyDefaultLotNr, viewModel.DefaultLotNr);
        if (TfLocation.IsValid) Preferences.Default.Set(KeyDefaultLocation, viewModel.DefaultLocation);

        base.OnNavigatingFrom(args);
    }
}