using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPLayerStrategy
{
    class BassTrebleEqualizer : IEqualizer
    {
        public SoundOutput SetEqualizer(IMedia song)
        {
            var compressionRatio = 1 - song.Compression;
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
