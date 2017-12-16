using DigitalAudioWorkstation.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.Domain.Services.MidiServices
{
    class MidiEffectService : IEffectService
    {
        IEffectFactory m_factory;

        public MidiEffectService(IEffectFactory factory)
        {
            m_factory = factory;
        }

        public IEffect CreateEffect(string id)
        {
            throw new NotImplementedException();
        }

        public IInstrument CreateInstrument(string id)
        {
            throw new NotImplementedException();
        }

        public IEffect GetEffect(string id)
        {
            throw new NotImplementedException();
        }

        public IInstrument GetInstrument(string id)
        {
            throw new NotImplementedException();
        }
    }
}
