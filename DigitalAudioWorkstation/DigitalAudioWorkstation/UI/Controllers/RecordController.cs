using DigitalAudioWorkstation.Entities;
using DigitalAudioWorkstation.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.UI.Controllers
{
    class RecordController
    {
        IRecordFacade m_recordFacade;

        public RecordController(IRecordFacade recordFacade)
        {
            m_recordFacade = recordFacade;
        }

        public IInput CreateInput(string id)
        {
            return m_recordFacade.CreateInput(id);
        }

        public ITrack CreateTrack(string id)
        {
            return m_recordFacade.CreateTrack(id);
        }

        public IInstrument CreateInstrument(string id)
        {
            return m_recordFacade.CreateInstrument(id);
        }

        public IClip RecordClip(string clipId, string trackId, string inputId, string instrumentId)
        {
            return m_recordFacade.RecordClip(clipId, trackId, inputId, instrumentId);
        }
    }
}
