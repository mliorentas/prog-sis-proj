using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Repository
{
    interface IEffectStore
    {
        IEffect AddOrReplaceEffect(IEffect effect);
        IEffect GetEffect(string id);
    }
}
