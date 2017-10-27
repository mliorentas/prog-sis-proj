using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPLayerStrategy
{
    class SimpleFormatter : ITitleFormater
    {
        public string FormatTitle(Song song)
        {
            StringBuilder titleBuilder = new StringBuilder();
            titleBuilder.Append(song.Artist);
            titleBuilder.Append(" - ");
            titleBuilder.Append(song.Title);

            return titleBuilder.ToString();
        }
    }
}
