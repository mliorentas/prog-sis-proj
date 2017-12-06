using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Midi;

namespace DigitalAudioWorkstation.Domain.Factories.Midi
{
    class MidiDeviceFactory : IDeviceFactory
    {
        public IInput CreateInput()
        {
            return new Keyboard();
        }
        public IOutput CreateOutput()
        {
            return new MidiOutput();
        }
    }
}
