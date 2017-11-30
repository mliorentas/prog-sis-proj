using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Midi;

namespace DigitalAudioWorkstation
{
    class MidiDevicesFactory
    {
        IInput CreateInput()
        {
            return new Keyboard();
        }
        IOutput CreateOutput()
        {
            return new MidiOutput();
        }
    }
}
