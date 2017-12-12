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
        IClip RecordClip(string id, ITrack track, IInput input, IInstrument instrument);
        ITrack RecordTrack(string id, IInput input, IInstrument instrument);
    }
}
