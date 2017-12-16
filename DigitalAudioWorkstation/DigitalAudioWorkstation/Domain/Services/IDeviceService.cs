using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Services
{
    interface IDeviceService
    {
        IInput CreateInput(string id);
        IOutput CreateOutput(string id);
        IInput GetInput(string id);
        IOutput GetOutput(string id);
        string RecordClipData(string id);
        string PlayTrack(IOutput output, string data);
    }
}
