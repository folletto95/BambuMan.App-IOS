using System.Drawing;
using LogLevel = BambuMan.Shared.Enums.LogLevel;

namespace BambuMan.Shared.Models
{
    public class LogModel(LogLevel level, string text)
    {
        public string ContentColor { get; private set; } = level switch
        {
            LogLevel.None or LogLevel.Trace or LogLevel.Debug => Color.DimGray.ToHex(),
            LogLevel.Information => Color.Black.ToHex(),
            LogLevel.Warning => Color.DarkOrange.ToHex(),
            LogLevel.Success => Color.DarkGreen.ToHex(),
            LogLevel.Error or LogLevel.Critical => Color.Maroon.ToHex(),
            _ => throw new ArgumentOutOfRangeException(nameof(level), level, null)
        };

        public string Content { get; private set; } = $"[{DateTime.Now:HH:mm:ss}]: {text}";
    }
}
