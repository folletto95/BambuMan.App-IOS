using BambuMan.Shared.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using BambuMan.Shared.Enums;

namespace BambuMan
{
    public partial class LogService : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<LogModel> logs = new();
        
        public Task AddLog(LogLevel level, string text)
        {
            Logs.Insert(0, new LogModel(level, text));

            return Task.CompletedTask;
        }
    }
}
