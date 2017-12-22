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
        public IEffect CreateEffect(string Id)
        {
            return new Reverb() { Id = Id, Effect = "Reverb, Large chamber preset" };
        }

        public IInstrument CreateInstrument(string Id)
        {
            return new Drums() { Id = Id, InstrumentInfo = "Sampled Drum set" };
        }
    }
}
