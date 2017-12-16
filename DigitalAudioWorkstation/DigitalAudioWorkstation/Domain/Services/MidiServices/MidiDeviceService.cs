using DigitalAudioWorkstation.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.Domain.Services.MidiServices
{
    class MidiDeviceService : IDeviceService
    {
        IDeviceFactory m_factory;

        public MidiDeviceService(IDeviceFactory factory)
        {
            m_factory = factory;
        }

        public IInput CreateInput(string id)
        {
            throw new NotImplementedException();
        }

        public IOutput CreateOutput(string id)
        {
            throw new NotImplementedException();
        }

        public IInput GetInput(string id)
        {
            throw new NotImplementedException();
        }

        public IOutput GetOutput(string id)
        {
            throw new NotImplementedException();
        }
    }
}
