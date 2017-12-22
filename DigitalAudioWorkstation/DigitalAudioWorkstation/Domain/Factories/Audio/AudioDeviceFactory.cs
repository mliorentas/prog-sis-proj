using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigitalAudioWorkstation.Entities.Audio;

namespace DigitalAudioWorkstation.Domain.Factories.Audio
{
    class AudioDeviceFactory : IDeviceFactory
    {
        public IInput CreateInput(string Id)
        {
            return new Microphone() { Id = Id , InputType = "Microphone, Condensator, Normalized "};

        }

        public IOutput CreateOutput(string Id)
        {
            return new Speakers() { Id = Id, OutputType = "Speakers, Stereo" };
        }
    }
}
