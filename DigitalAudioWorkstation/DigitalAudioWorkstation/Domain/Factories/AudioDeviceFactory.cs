using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Audio;

namespace DigitalAudioWorkstation
{
    class AudioDeviceFactory
    {
        IInput CreateInput()
        {
            return new Microphone();
        }

        IOutput CreateOutput()
        {
            return new Speakers();
        }
    }
}
