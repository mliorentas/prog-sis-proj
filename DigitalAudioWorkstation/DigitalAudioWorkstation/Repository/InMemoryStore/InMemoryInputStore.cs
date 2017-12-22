using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Repository
{
    class InMemoryInputStore : IInputStore
    {
        private List<IInput> m_inputs = new List<IInput>();

        public IInput AddOrReplaceInput(IInput input)
        {
            var existing = GetInput(input.Id);
            if (null != existing)
            {
                m_inputs.Remove(existing);
            }

            m_inputs.Add(input);
            return input;
        }
        public IInput GetInput(string id)
        {
            return m_inputs.FirstOrDefault(input => input.Id == id);
        }
    }
}
