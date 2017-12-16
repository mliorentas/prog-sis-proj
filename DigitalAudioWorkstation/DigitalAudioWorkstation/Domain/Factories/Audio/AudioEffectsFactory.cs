using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Factories.Audio
{
    class AudioEffectsFactory : IEffectFactory
    {

        public IEffect CreateEffect(string Id)
        {
            return new EQ() { Id = Id , Effect = "EQ, Mid Highs, Loud Lows "};
        }

        public IInstrument CreateInstrument(string Id)
        {
            return new Sampler() { Id = Id, InstrumentInfo = "Sampler" };
        }
    }
}
