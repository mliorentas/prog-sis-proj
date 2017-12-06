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

        public IClip CreateClip()
        {
            throw new NotImplementedException();
        }

        public ITrack CreateTrack()
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
