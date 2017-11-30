using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation
{
    interface IEffectFactory
    {
        IAudioEffect CreateEffect();
        IAudioEffect CreateMutedEffect();
    }
}
