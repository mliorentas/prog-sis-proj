using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Domain.Services;

namespace DigitalAudioWorkstation.Facade
{
    class AudioRecordFacade : IRecordFacade
    {
        ITrackService m_trackService;
        IDeviceService m_deviceService;
        IEffectService m_instrumentService;

        public AudioRecordFacade (ITrackService trackService, IDeviceService deviceService, IEffectService instrumentService)
        {
            m_trackService = trackService;
            m_deviceService = deviceService;
            m_instrumentService = instrumentService;
        }

        public IInput CreateInput(string id)
        {
            return m_deviceService.CreateInput(id);
        }

        public IInstrument CreateInstrument(string id)
        {
            return m_instrumentService.CreateInstrument(id);
        }

        public ITrack CreateTrack(string id)
        {
            return m_trackService.CreateTrack(id);
        }

        public IClip RecordClip(string clipId, string trackId, string inputId, string instrumentId)
        {
            m_trackService.AddEffect(trackId, m_instrumentService.GetEffectData(instrumentId));
            var clip = m_trackService.CreateClip(clipId);
            m_trackService.AddRecording(clipId, m_deviceService.RecordClipData(inputId));
            return clip;
        }
    }
}
