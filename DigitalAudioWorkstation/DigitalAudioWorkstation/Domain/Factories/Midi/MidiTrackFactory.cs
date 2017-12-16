using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Audio;
using DigitalAudioWorkstation.Entities.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Factories.Midi
{
    class MidiTrackFactory : ITrackFactory
    {
        public ITrack CreateTrack(string Id)
        {
            return new MidiTrack() { Id = Id, TrackInfo = "Midi Track, WAV format" };
        }

        public IClip CreateClip(string Id)
        {
            return new MidiClip() { Id = Id, Data = "Midi Clip recorded at " + System.DateTime.Now.ToString() };
        }
    }
}
