﻿using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Repository
{
    interface IInputStore
    {
        IInput AddOrReplaceInput(IInput input);
        IInput GetInput(string id);
    }
}
