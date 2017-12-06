using DigitalAudioWorkstation.Domain.Factories;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Services.AudioServices
{
    class AudioTrackService : ITrackService
    {
        ITrackFactory m_factory;
        ITrackStore m_store;

        public AudioTrackService(ITrackFactory factory, ITrackStore store)
        {
            m_factory = factory;
            m_store = store;
        }

        public IClip CreateClip()
        {
            return m_factory.CreateClip();
        }

        public ITrack CreateTrack()
        {
            return m_factory.CreateTrack();
        }

        public ITrack InsertClip(ITrack track, double time)
        {
            throw new NotImplementedException();
        }
    }
}
