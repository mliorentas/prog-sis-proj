using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class IMusicPlayer
    {
        public SoundOutput PlaySong(Song song)
        {
            SetEqualizer(song);
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
                FormatTitle(song);
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
