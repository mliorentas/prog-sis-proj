using DigitalAudioWorkstation.Domain.Factories;

namespace DigitalAudioWorkstation.Domain.Services.AudioServices
{
    class AudioDeviceService
    {
        IDeviceFactory m_factory;

        public AudioDeviceService(IDeviceFactory factory)
        {
            m_factory = factory;
        }
    }
}
