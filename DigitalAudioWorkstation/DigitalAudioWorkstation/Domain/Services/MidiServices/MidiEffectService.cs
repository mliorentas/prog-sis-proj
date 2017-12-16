using DigitalAudioWorkstation.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Repository;

namespace DigitalAudioWorkstation.Domain.Services.MidiServices
{
    class MidiEffectService : IEffectService
    {
        IEffectFactory m_factory;
        IEffectStore m_effectStore;
        IInstrumentStore m_instrumentStore;

        public MidiEffectService(IEffectFactory factory, IEffectStore effectStore, IInstrumentStore instrumentStore)
        {
            m_factory = factory;
            m_effectStore = effectStore;
            m_instrumentStore = instrumentStore;
        }

        public IEffect CreateEffect(string id)
        {
            var efect = m_factory.CreateEffect(id);
            return m_effectStore.AddOrReplaceEffect(efect);
        }

        public IInstrument CreateInstrument(string id)
        {
            var instrument = m_factory.CreateInstrument(id);
            return m_instrumentStore.AddOrReplaceInstrument(instrument);
        }

        public IEffect GetEffect(string id)
        {
            return m_effectStore.GetEffect(id);
        }

        public string GetEffectData(string id)
        {
            var effect = GetEffect(id);
            if (null == effect)
                return String.Empty;

            return effect.Effect;
        }

        public IInstrument GetInstrument(string id)
        {
            return m_instrumentStore.GetInstrument(id);
        }

        public string GetInstrumentData(string id)
        {
            var instrument = GetInstrument(id);
            if (null == instrument)
                return String.Empty;

            return instrument.InstrumentInfo;
        }
    }
}
