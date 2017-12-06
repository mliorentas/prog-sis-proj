using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Audio;
using DigitalAudioWorkstation.Entities.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Factories.Audio
{
    class AudioTrackFactory : ITrackFactory
    {
        public ITrack CreateTrack()
        {
            return new AudioTrack();
        }
        public IClip CreateClip()
        {
            return new AudioClip();
        }
    }
}
