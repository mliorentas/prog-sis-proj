using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigitalAudioWorkstation.Entities.Midi;

namespace DigitalAudioWorkstation.Domain.Factories.Midi
{
    class MidiDeviceFactory : IDeviceFactory
    {
        public IInput CreateInput(string Id)
        {
            return new Keyboard() { Id = Id, InputType = "E-Piano Keyboard, Yamaha E-4562" };

        }

        public IOutput CreateOutput(string Id)
        {
            return new MidiOutput() { Id = Id, OutputType = "Midi Output, Virtual Midi Track " };
        }
    }
}
