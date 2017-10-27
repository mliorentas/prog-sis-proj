using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class BassTrebleMoviePlayer : AbstractMoviePlayer
    {
        protected override SoundOutput SetEqualizer(Movie movie)
        {
            var compressionRatio = 1 - movie.Compression;
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
