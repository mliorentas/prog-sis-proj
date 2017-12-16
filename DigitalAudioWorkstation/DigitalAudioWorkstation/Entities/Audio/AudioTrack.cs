using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities.Audio
{
    class AudioTrack : ITrack
    {
        public string Id { get; set; }
        public List<IClip> Clips { get; set; }
        public string TrackInfo { get; set; }
    }
}
