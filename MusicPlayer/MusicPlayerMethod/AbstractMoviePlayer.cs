using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    abstract class AbstractMoviePlayer
    {
        abstract protected SoundOutput SetEqualizer(Movie movie);

        public SoundOutput PlayMovie(Movie movie)
        {
            var sound = SetEqualizer(movie);
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
