using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Factories
{
    interface IEffectFactory
    {
        IEffect CreateEffect(string Id);
        IInstrument CreateInstrument(string Id);
    }
}
