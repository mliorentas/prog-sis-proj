using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Entities.Audio;
using DigitalAudioWorkstation.Entities.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation
{
    class MidiTrackFactory
    {
        ITrack CreateTrack()
        {
            return new MidiTrack();
        }
        IClip CreateClip()
        {
            return new MidiClip();
        }
    }
}
