using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation
{
    class MidiInstrumentFactory
    {
        IEffect CreateEffect()
        {
            return new Reverb();
        }
        IInstrument CreateInstrument()
        {
            return new Drums();
        }
    }
}
