using DigitalAudioWorkstation.Domain.Factories;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Repository;
using System;

namespace DigitalAudioWorkstation.Domain.Services.AudioServices
{
    class AudioDeviceService : IDeviceService
    {
        IDeviceFactory m_factory;
        IInputStore m_inputStore;
        IOutputStore m_outputStore;

        public AudioDeviceService(IDeviceFactory factory, IInputStore inputStore, IOutputStore outputStore)
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

            return String.Format("{0} audio recorded clip at {1}.", input.InputType, DateTime.Now.ToString());
        }
    }
}
