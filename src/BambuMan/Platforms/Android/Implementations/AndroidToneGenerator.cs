using Android.Media;
using BambuMan.Shared.Interfaces;
using Stream = Android.Media.Stream;

namespace BambuMan.Implementations
{
    public class AndroidToneGenerator : IToneGenerator
    {
        private readonly ToneGenerator toneGenerator = new(Stream.Notification, 100);

        private readonly ToneGenerator toneSystemGenerator = new(Stream.System, 100);
    
        private readonly ToneGenerator alarmToneGenerator = new(Stream.Alarm, 100);

        public async Task PlayTone()
        {
            await Task.Run(() => { toneGenerator?.StartTone(Tone.CdmaPip, 20); });
        }
    
        public async Task PlayToneSuccess()
        {
            await Task.Run(() => { toneGenerator?.StartTone(Tone.CdmaPip, 60); });
        }

        public async Task PlaySystemTone()
        {
            await Task.Run(() => { toneSystemGenerator?.StartTone(Tone.CdmaSoftErrorLite, 20); });
        }

        public async Task PlayAlarmTone()
        {
            await Task.Run(() => { alarmToneGenerator?.StartTone(Tone.SupError, 120); });
        }
    }
}
