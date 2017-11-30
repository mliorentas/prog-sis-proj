using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain
{
    class AudioTrackService : ITrackService
    {
        ITrackFactory m_factory;

        public AudioTrackService(ITrackFactory factory)
        {
            m_factory = factory;
        }

        public IClip CreateClip()
        {
            return m_factory.CreateClip();
        }

        public ITrack CreateTrack()
        {
            return m_factory.CreateTrack();
        }

        public ITrack SetMute(ITrack track, bool muted)
        {
            track.IsMuted = muted;
            return track;
        }

        public IClip Duplicate(IClip clip)
        {
            var newClip = m_factory.CreateClip();
            newClip.Id = clip.Id;
            return newClip;
        }
    }
}
