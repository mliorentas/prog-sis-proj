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
    class AudioTrackFactory
    {
        ITrack CreateTrack()
        {
            return new AudioTrack();
        }
        IClip CreateClip()
        {
            return new AudioClip();
        }
    }
}
