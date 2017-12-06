using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Factories.Midi
{
    class MidiInstrumentFactory : IEffectFactory
    {
        public IEffect CreateEffect()
        {
            return new Reverb();
        }
        public IInstrument CreateInstrument()
        {
            return new Drums();
        }
    }
}
