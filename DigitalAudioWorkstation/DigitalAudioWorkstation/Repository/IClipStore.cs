using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Repository
{
    interface IClipStore
    {
        IClip AddOrReplaceClip(IClip clip);
        IClip GetClip(string id);
    }
}
