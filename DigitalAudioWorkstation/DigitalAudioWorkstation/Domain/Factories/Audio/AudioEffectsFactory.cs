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
        public IEffect CreateEffect()
        {
            return new EQ();
        }
        public IInstrument CreateInstrument()
        {
            return new Sampler();
        }
    }
}
