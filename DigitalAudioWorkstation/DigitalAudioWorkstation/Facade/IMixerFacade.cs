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
        IOutput CreateOutput(string id);
        IEffect CreateEffect(string id);

        string PlayTrack(string trackId, string outputId, string effectId);
    }
}
