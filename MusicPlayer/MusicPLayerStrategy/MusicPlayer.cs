using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPLayerStrategy
{
    class MusicPlayer
    {
        private IEqualizer _eq;
        private ITitleFormater _formater;


        public MusicPlayer(IEqualizer eq, ITitleFormater formater)
        {
            _eq = eq;
            _formater = formater;
        }
        public SoundOutput PlaySong(Song song)
        {
            var sound = _eq.SetEqualizer(song);
            Console.Out.WriteLine(_formater.FormatTitle(song));
            Console.Out.WriteLine("Lows - " + sound.Lows);
            Console.Out.WriteLine("Mids - " + sound.Mids);
            Console.Out.WriteLine("Highs - " + sound.Highs);
            Console.Out.WriteLine("Balance - " + sound.Balance);
            Console.Out.WriteLine();
            return sound;
        }

        public void DisplayPlaylist(List<Song> songs)
        {
            foreach(var song in songs)
            {
                _formater.FormatTitle(song);
            }
        }

    }
}
