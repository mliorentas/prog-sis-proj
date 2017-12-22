using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities.Midi
{
    class MidiTrack : ITrack
    {
        public string Id { get; set; }
        public List<IClip> Clips { get; set; } = new List<IClip>();
        public string TrackInfo { get; set; }
    }
}
