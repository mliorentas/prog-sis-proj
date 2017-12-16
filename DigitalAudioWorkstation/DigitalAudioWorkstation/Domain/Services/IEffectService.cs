using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain.Services
{
    interface IEffectService
    {
        IInstrument CreateInstrument(string id);
        IEffect CreateEffect(string id);
        IInstrument GetInstrument(string id);
        IEffect GetEffect(string id);
        string GetInstrumentData(string id);
        string GetEffectData(string id);
    }
}
