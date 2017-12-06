using DigitalAudioWorkstation.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Services.MidiServices
{
    class MidiEffectService : IEffectService
    {
        IEffectFactory m_factory;

        public MidiEffectService(IEffectFactory factory)
        {
            m_factory = factory;
        }
    }
}
