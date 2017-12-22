using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.Repository
{
    class InMemoryInstrumentStore : IInstrumentStore
    {
        private List<IInstrument> m_instruments = new List<IInstrument>();

        public IInstrument AddOrReplaceInstrument(IInstrument instrument)
        {
            var existing = GetInstrument(instrument.Id);
            if (null != existing)
            {
                m_instruments.Remove(existing);
            }

            m_instruments.Add(instrument);
            return instrument;
        }
        public IInstrument GetInstrument(string id)
        {
            return m_instruments.FirstOrDefault(instrument => instrument.Id == id);
        }
    }
}
