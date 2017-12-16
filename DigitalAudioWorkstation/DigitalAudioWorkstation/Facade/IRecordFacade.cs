using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Facade
{
    interface IRecordFacade
    {
        IInput CreateInput(string id);
        ITrack CreateTrack(string id);
        IInstrument CreateInstrument(string id);

        IClip RecordClip(string clipId, string trackId, string inputId, string instrumentId);
    }
}
