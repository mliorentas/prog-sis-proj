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
        ITrack InsertClip(ITrack track, IClip clip);
        IClip CreateClip(string id);
        ITrack GetTrack(string id);
    }
}
