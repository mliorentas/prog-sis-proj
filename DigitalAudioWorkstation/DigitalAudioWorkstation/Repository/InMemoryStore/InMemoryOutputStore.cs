using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.Repository
{
    class InMemoryOutputStore : IOutputStore
    {
        private List<IOutput> m_outputs = new List<IOutput>();

        public IOutput AddOrReplaceOutput(IOutput output)
        {
            var existing = GetOutput(output.Id);
            if (null == existing)
            {
                m_outputs.Remove(existing);
            }

            m_outputs.Add(output);
            return output;
        }
        public IOutput GetOutput(string id)
        {
            return m_outputs.FirstOrDefault(output => output.Id == id);
        }
    }
}
