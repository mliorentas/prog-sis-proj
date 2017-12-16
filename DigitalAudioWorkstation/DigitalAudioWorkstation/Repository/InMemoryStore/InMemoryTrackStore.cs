using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.Repository
{
    class InMemoryTrackStore : ITrackStore
    {
        private List<ITrack> m_tracks = new List<ITrack>();

        public ITrack AddOrReplaceTrack(ITrack track)
        {
            var existing = GetTrack(track.Id);
            if (null == existing)
            {
                m_tracks.Remove(existing);
            }

            m_tracks.Add(track);
            return track;
        }
        public ITrack GetTrack(string id)
        {
            return m_tracks.FirstOrDefault(track => track.Id == id);
        }
    }
}
