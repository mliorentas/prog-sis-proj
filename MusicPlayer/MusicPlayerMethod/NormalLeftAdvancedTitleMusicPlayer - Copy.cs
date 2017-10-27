using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class NormalLeftMoviePlayer : AbstractMoviePlayer
    {
        protected override SoundOutput SetEqualizer(Movie movie)
        {
            var sound = new SoundOutput();
            sound.Balance = -100;
            sound.Highs = 0;
            sound.Lows = 0;
            sound.Mids = 0;
            return sound;
        }

    }
}
