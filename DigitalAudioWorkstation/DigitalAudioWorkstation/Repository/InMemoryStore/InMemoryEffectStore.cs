using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Repository
{
    class InMemoryEffectStore
    {
        private List<IEffect> m_effects = new List<IEffect>();

        IEffect AddEffect(IEffect effect)
        {
            m_effects.Add(effect);
            return effect;
        }
        IEffect GetEffect(string id)
        {
            return m_effects.FirstOrDefault(effect => effect.Id == id);
        }
    }
}
