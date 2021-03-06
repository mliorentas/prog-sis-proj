﻿using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.UI.Controllers
{
    class MixerController
    {
        IMixerFacade m_mixerFacade;

        public MixerController(IMixerFacade mixer)
        {
            m_mixerFacade = mixer;
        }

        public IOutput CreateOutput(string id)
        {
            return m_mixerFacade.CreateOutput(id);
        }
        public IEffect CreateEffect(string id)
        {
            return m_mixerFacade.CreateEffect(id);
        }

        public string PlayTrack(string trackId, string outputId, string effectId)
        {
            return m_mixerFacade.PlayTrack(trackId, outputId, effectId);
        }
    }
}
