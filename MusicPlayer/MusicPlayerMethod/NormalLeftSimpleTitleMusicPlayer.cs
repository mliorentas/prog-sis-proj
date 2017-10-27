using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class NormalLeftSimpleTitleMusicPlayer : AbstractMusicPlayer
    {
        protected override SoundOutput SetEqualizer(Song song)
        {
            var sound = new SoundOutput();
            sound.Balance = -100;
            sound.Highs = 0;
            sound.Lows = 0;
            sound.Mids = 0;
            return sound;
        }
        protected override string FormatTitle(Song song)
        {
            StringBuilder titleBuilder = new StringBuilder();
            titleBuilder.Append(song.Artist);
            titleBuilder.Append(" - ");
            titleBuilder.Append(song.Title);

            return titleBuilder.ToString();
        }
    }
}
