using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPLayerStrategy
{
    class MoviePlayer
    {
        private IEqualizer _eq;

        public MoviePlayer(IEqualizer eq)
        {
            _eq = eq;
        }
        public SoundOutput PlayMovie(IMedia movie)
        {
            var sound = _eq.SetEqualizer(movie);
            Console.Out.WriteLine(movie.Title);
            Console.Out.WriteLine("Lows - " + sound.Lows);
            Console.Out.WriteLine("Mids - " + sound.Mids);
            Console.Out.WriteLine("Highs - " + sound.Highs);
            Console.Out.WriteLine("Balance - " + sound.Balance);
            Console.Out.WriteLine();
            return sound;
        }
    }
}
