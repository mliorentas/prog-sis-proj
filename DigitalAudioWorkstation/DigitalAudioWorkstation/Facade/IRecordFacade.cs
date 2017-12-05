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
        ITrack RecordTrack();
        ITrack PlayTrack();
        IClip ApllyEffect(IClip clip, IEffect effect);

    }
}
