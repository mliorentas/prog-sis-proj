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
    class MidiDeviceService : IDeviceService
    {
        IDeviceFactory m_factory;
        IInputStore m_inputStore;
        IOutputStore m_outputStore;

        public MidiDeviceService(IDeviceFactory factory, IInputStore inputStore, IOutputStore outputStore)
        {
            m_factory = factory;
            m_inputStore = inputStore;
            m_outputStore = outputStore;
        }

        public IInput CreateInput(string id)
        {
            var input = m_factory.CreateInput(id);
            return m_inputStore.AddOrReplaceInput(input);
        }

        public IOutput CreateOutput(string id)
        {
            var output = m_factory.CreateOutput(id);
            return m_outputStore.AddOrReplaceOutput(output);
        }

        public IInput GetInput(string id)
        {
            return m_inputStore.GetInput(id);
        }

        public IOutput GetOutput(string id)
        {
            return m_outputStore.GetOutput(id);
        }

        public string PlayTrack(IOutput output, string data)
        {
            return data + output.OutputType;
        }

        public string RecordClipData(string id)
        {
            var input = m_inputStore.GetInput(id);
            if (null == input)
                return string.Empty;

            return String.Format("{0} midi recorded clip at {1}.", input.InputType, DateTime.Now.ToString());
        }
    }
}
