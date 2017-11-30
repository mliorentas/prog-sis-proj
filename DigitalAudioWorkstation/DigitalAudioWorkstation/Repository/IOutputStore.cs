﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.Repository
{
    interface IOutputStore
    {
        IOutput AddOutput(IOutput output);
        IOutput GetOutput(string id);
    }
}
