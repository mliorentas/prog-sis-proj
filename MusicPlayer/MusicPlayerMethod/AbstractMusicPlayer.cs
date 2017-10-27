using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    abstract class AbstractMusicPlayer
    {
        abstract protected SoundOutput SetEqualizer(Song song);
        abstract protected string FormatTitle(Song song);

        public SoundOutput PlaySong(Song song)
        {
            var sound = SetEqualizer(song);
            Console.Out.WriteLine(FormatTitle(song));
            Console.Out.WriteLine("Lows - " + sound.Lows);
            Console.Out.WriteLine("Mids - " + sound.Mids);
            Console.Out.WriteLine("Highs - " + sound.Highs);
            Console.Out.WriteLine("Balance - " + sound.Balance);
            Console.Out.WriteLine();
            return sound;
        }
    }
}
