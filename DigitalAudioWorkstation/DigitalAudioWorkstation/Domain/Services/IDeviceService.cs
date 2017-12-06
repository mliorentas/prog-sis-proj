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
    }
}
