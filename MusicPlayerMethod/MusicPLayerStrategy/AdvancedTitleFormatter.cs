using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPLayerStrategy
{
    class AdvancedTitleFormatter : ITitleFormater
    {
        public string FormatTitle(Song song)
        {
            StringBuilder titleBuilder = new StringBuilder();
            titleBuilder.Append(song.Artist.ToUpper());
            titleBuilder.Append(" - ");
            titleBuilder.Append(song.Title.ToUpper());
            titleBuilder.Append(" - ");
            titleBuilder.Append(song.Album.ToUpper());

            return titleBuilder.ToString();
        }
    }
}
