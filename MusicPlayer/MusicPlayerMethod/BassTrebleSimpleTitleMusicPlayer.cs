using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class BassTrebleSimpleTitleMusicPlayer : AbstractMusicPlayer
    {
        protected override SoundOutput SetEqualizer(Song song)
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
