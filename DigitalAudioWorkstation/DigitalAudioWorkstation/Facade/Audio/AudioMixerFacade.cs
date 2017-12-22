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
                return "No track";
            var output = m_deviceService.GetOutput(outputId);
            if (null == output)
                return "No output";
            if (null == track.Clips)
                return "No clips";
            var clips = track.Clips.Select(clip => clip.Data);
            if (null == clips)
                return "No clips";
            var effect = m_instrumentService.GetEffect(effectId);
            if (null == effect)
                return "No effect";
            return m_deviceService.PlayTrack(output, track.TrackInfo + " " + effect.Effect + " \n"  + String.Join("\n", clips.ToList()));
        }
    }
}
