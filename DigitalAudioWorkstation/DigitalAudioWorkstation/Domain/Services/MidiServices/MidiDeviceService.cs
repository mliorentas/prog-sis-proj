using DigitalAudioWorkstation.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Services.MidiServices
{
    class MidiDeviceService : IDeviceService
    {
        IDeviceFactory m_factory;

        public MidiDeviceService(IDeviceFactory factory)
        {
            m_factory = factory;
        }
    }
}
