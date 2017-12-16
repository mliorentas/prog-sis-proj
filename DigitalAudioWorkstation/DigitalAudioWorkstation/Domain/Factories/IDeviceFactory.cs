using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalAudioWorkstation.Domain.Factories
{
    interface IDeviceFactory
    {
        IInput CreateInput();
        IOutput CreateOutput();
    }
}
