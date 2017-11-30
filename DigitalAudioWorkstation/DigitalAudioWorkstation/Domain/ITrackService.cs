using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain
{
    interface ITrackService
    {
        ITrack AddTrack();
        ITrackFactory ExtendTrack(ITrack track);
    }
}
