﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities.Midi
{
    class MidiClip : IClip
    {
        public string Id { get; set; }
        public string Data { get; set; }
    }
}
