using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Facade
{
    interface IMixerFacade
    {
        ITrack PlayTrack(ITrack track, IOutput output, IEffect effect);
        IClip ApllyEffect(IClip clip, IEffect effect);
    }
}
