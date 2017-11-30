using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation
{
    interface IDeviceFactory
    {
        IInput CreateInput();
        IOutput CreateOutput();
    }
}
