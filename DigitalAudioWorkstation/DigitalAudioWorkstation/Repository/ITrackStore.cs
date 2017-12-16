using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.Repository
{
    interface ITrackStore
    {
        ITrack AddOrReplaceTrack(ITrack track);
        ITrack GetTrack(string id);
    }
}
