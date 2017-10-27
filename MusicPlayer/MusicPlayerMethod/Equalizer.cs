using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class Equalizer
    {
        static SoundOutput NormalLeft(IMedia media)
        {
            var sound = new SoundOutput();
            sound.Balance = -100;
            sound.Highs = 0;
            sound.Lows = 0;
            sound.Mids = 0;
            return sound;
        }
        static SoundOutput BassTreble(IMedia media)
        {
            var compressionRatio = 1 - media.Compression;
            var sound = new SoundOutput()
            {
                Highs = compressionRatio * 70,
                Lows = compressionRatio * 80,
                Mids = compressionRatio * 10,
                Balance = 0
            };
            return sound;
        }
    }
}
