using BambuMan.Shared.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BambuMan.UI.Logs
{
    public partial class LogsPageViewModel(LogService logService) : ObservableObject, IQueryAttributable
    {
        [ObservableProperty] private ObservableCollection<LogModel> logs = logService.Logs;

        public async void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            //await Task.Delay(500);
            //SpoolmanUrl = query["url"] as string ?? Preferences.Default.Get("spoolman_url", string.Empty);
        }
    }
}
