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
        public ITrack CreateTrack(string Id)
        {
            return new AudioTrack() { Id = Id, TrackInfo = "Audio Track, WAV format" };
        }

        public IClip CreateClip(string Id)
        {
            return new AudioClip() { Id = Id , Data = "Midi Clip"};
        }
    }
}
