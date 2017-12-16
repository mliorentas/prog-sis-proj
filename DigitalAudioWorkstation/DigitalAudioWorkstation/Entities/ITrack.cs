using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities
{
    interface ITrack
    {
        string Id { get; set; }
        List<IClip> Clips { get; set; }
        string TrackInfo { get; set; }
    }
}
