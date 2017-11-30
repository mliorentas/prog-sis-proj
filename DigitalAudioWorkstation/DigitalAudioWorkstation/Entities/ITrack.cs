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
        bool IsMuted { get; set; }
        float Pan { get; set; }
        float Volume { get; set; }
    }
}
