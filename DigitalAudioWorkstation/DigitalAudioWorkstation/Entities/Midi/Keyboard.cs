﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities.Midi
{
    class Keyboard : IInput
    {
        public string Id { get; set; }
        public string InputType { get; set; }
    }
}
