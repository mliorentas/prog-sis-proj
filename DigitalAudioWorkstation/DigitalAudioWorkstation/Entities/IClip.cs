﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities
{
    interface IClip
    {
        string Id { get; set; }
        string Data { get; set; }
    }
}
