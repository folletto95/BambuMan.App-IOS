using CommunityToolkit.Mvvm.ComponentModel;

namespace BambuMan.UI.Settings
{
    public partial class SettingsPageViewModel : ObservableObject, IQueryAttributable
    {
        [ObservableProperty] private string? spoolmanUrl;
        [ObservableProperty] private decimal? defaultPrice;
        [ObservableProperty] private string? defaultLotNr;
        [ObservableProperty] private string? defaultLocation;
        [ObservableProperty] private DateTime? buyDate;

        public async void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            await Task.Delay(500);
            SpoolmanUrl = query["url"] as string ?? Preferences.Default.Get("spoolman_url", string.Empty);
        }
    }
}
