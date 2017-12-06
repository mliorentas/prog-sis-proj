﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities.Midi
{
    class MidiTrack : ITrack
    {
        public string Id { get; set; }
        public bool IsMuted { get; set; }
        public float Pan { get; set; }
        public float Volume { get; set; }
    }
}
