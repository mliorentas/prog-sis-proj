﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities
{
    interface IInput
    {
        string Id { get; set; }
        string InputType { get; set; }
    }
}
