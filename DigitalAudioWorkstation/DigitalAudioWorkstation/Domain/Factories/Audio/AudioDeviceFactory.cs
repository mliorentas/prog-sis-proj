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
        public IInput CreateInput()
        {
            return new Microphone();
        }

        public IOutput CreateOutput()
        {
            return new Speakers();
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
