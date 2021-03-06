﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.Repository
{
    interface IInstrumentStore
    {
        IInstrument AddOrReplaceInstrument(IInstrument instrument);
        IInstrument GetInstrument(string id);
    }
}
