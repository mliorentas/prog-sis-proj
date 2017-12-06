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
        public ITrack CreateTrack()
        {
            return new MidiTrack();
        }
        public IClip CreateClip()
        {
            return new MidiClip();
        }
    }
}
