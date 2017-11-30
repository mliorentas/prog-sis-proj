using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation
{
    class AudioEffectsFactory
    {
        IEffect CreateEffect()
        {
            return new EQ();
        }
        IInstrument CreateInstrument()
        {
            return new Sampler();
        }
    }
}
