using DigitalAudioWorkstation.Domain.Services;
using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Facade
{
    class AudioMixerFacade : IMixerFacade
    {
        ITrackService m_trackService;
        IDeviceService m_deviceService;
        IEffectService m_instrumentService;

        public AudioMixerFacade(ITrackService trackService, IDeviceService deviceService, IEffectService instrumentService)
        {
            m_trackService = trackService;
            m_deviceService = deviceService;
            m_instrumentService = instrumentService;
        }
        public IOutput CreateOutput(string id)
        {
            return m_deviceService.CreateOutput(id);
        }

        public IEffect CreateEffect(string id)
        {
            return m_instrumentService.CreateEffect(id);
        }

        public string PlayTrack(string trackId, string outputId, string effectId)
        {
            var track = m_trackService.GetTrack(trackId);
            if (null == track)
                return String.Empty;

            m_instrumentService.GetEffect(effectId);
            return m_deviceService.PlayTrack(m_deviceService.GetOutput(outputId), track.TrackInfo + " " + m_instrumentService.GetEffect(effectId).Effect + " "  + track.Clips.Select(clip => clip.Data).ToString());
        }
    }
}
