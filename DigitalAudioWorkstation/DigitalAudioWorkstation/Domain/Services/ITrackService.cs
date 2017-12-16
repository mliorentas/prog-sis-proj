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
        void AddClip(ITrack track, IClip clip);
        ITrack GetTrack(string id);
        IClip GetClip(string id);
        void AddEffect(string trackId, string data);
        void AddRecording(string clipId, string data);
        string GetTrackData(string id);
    }
}
