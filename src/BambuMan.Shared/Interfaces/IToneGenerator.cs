using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambuMan.Shared.Interfaces
{
    public interface IToneGenerator
    {
        Task PlayTone();
        Task PlaySystemTone();
        Task PlayAlarmTone();
        Task PlayToneSuccess();
    }
}
