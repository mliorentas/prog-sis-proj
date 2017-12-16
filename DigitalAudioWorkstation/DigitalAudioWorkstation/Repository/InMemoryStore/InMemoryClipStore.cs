using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Repository
{
    class InMemoryClipStore : IClipStore
    {
        private List<IClip> m_clips = new List<IClip>();

        public IClip AddOrReplaceClip(IClip clip)
        {
            var existing = GetClip(clip.Id);
            if (null == existing)
            {
                m_clips.Remove(existing);
            }

            m_clips.Add(clip);
            return clip;
        }
        public IClip GetClip(string id)
        {
            return m_clips.FirstOrDefault(clip => clip.Id == id);
        }
    }
}
