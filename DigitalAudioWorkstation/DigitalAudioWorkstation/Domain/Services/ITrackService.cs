﻿using DigitalAudioWorkstation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Domain
{
    interface ITrackService
    {
        ITrack CreateTrack();
        ITrack SetMute(ITrack track, bool muted);
        ITrack InsertClip(ITrack track, double time);
        IClip CreateClip();
        IClip Duplicate(IClip track);
    }
}
