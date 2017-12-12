using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Services
{
    interface ITrackService
    {
        ITrack CreateTrack(string id);
        IClip CreateClip(string id);
        ITrack AddClip(ITrack track, IClip clip);
        ITrack GetTrack(string id);
        IClip GetClip(string id, ITrack track);
    }
}
