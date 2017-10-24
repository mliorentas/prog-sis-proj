using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class IMusicPlayer
    {
        private IEqualizer _eq;
        private ITitleFormater _formater;


        public IMusicPlayer(IEqualizer eq, ITitleFormater formater)
        {
            _eq = eq;
            _formater = formater;
        }
        public SoundOutput PlaySong(Song song)
        {
            _eq.SetEqualizer(song);
            Normalize(song);
            Balance(song);
            return new SoundOutput();
        }

        protected void Balance(Song song)
        {
            throw new NotImplementedException();
        }

        protected void Normalize(Song song)
        {
            throw new NotImplementedException();
        }

        protected void SetEqualizer(Song song)
        {
            throw new NotImplementedException();
        }

        public void DisplayPlaylist(Song [] songs)
        {
            foreach(var song in songs)
            {
                _formater.FormatTitle(song);
                FormatDescription(song);
                FormatRating(song);
            }


        }

        protected void FormatRating(Song song)
        {
            throw new NotImplementedException();
        }

        protected void FormatDescription(Song song)
        {
            throw new NotImplementedException();
        }

        protected void FormatTitle(Song song1)
        {
            throw new NotImplementedException();
        }

    }
}
