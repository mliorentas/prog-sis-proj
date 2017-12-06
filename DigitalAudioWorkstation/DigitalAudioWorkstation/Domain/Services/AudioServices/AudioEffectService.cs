using DigitalAudioWorkstation.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Services.AudioServices
{
    class AudioEffectService
    {
        IEffectFactory m_factory;

        public AudioEffectService(IEffectFactory factory)
        {
            m_factory = factory;
        }
    }
}
