using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Domain.Factories;

namespace DigitalAudioWorkstation.Domain.Services.MidiServices
{
    class MidiTrackService : ITrackService
    {
        ITrackFactory m_factory;

        public MidiTrackService(ITrackFactory factory)
        {
            m_factory = factory;
        }

        public ITrack AddClip(ITrack track, IClip clip)
        {
            throw new NotImplementedException();
        }

        public IClip CreateClip()
        {
            throw new NotImplementedException();
        }

        public IClip CreateClip(string id)
        {
            throw new NotImplementedException();
        }

        public ITrack CreateTrack()
        {
            throw new NotImplementedException();
        }

        public ITrack CreateTrack(string id)
        {
            throw new NotImplementedException();
        }

        public IClip GetClip(string id, ITrack track)
        {
            throw new NotImplementedException();
        }

        public ITrack GetTrack(string id)
        {
            throw new NotImplementedException();
        }

        public ITrack InsertClip(ITrack track, double time)
        {
            throw new NotImplementedException();
        }

        public ITrack SetMute(ITrack track, bool muted)
        {
            throw new NotImplementedException();
        }
    }
}
