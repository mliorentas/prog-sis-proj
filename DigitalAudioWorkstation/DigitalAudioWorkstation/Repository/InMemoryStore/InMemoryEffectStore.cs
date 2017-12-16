using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Repository
{
    class InMemoryEffectStore : IEffectStore
    {
        private List<IEffect> m_effects = new List<IEffect>();

        public IEffect AddOrReplaceEffect(IEffect effect)
        {
            var existing = GetEffect(effect.Id);
            if (null == existing)
            {
                m_effects.Remove(existing);
            }
            m_effects.Add(effect);
            return effect;
        }
        public IEffect GetEffect(string id)
        {
            return m_effects.FirstOrDefault(effect => effect.Id == id);
        }
    }
}
