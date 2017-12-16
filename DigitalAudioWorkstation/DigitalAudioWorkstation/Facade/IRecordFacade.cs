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
        IClip RecordClip(string id, string trackId, string inputId, string instrumentId);
        ITrack RecordTrack(string id, string inputId, string instrumentId);
    }
}
