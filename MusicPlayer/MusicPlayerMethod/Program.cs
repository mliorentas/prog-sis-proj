using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var song = new Song("My Heart Will Go On", "Celine Dion", "Let's Talk About Love", 0.42f);
            var movie = new Movie("Titanic", 0.1f);

            var leftSimpleMusicPlayer = new NormalLeftSimpleTitleMusicPlayer();
            var leftAdvancedMusicPlayer = new NormalLeftAdvancedTitleMusicPlayer();
            var bassSimpleTreblePlayer = new BassTrebleSimpleTitleMusicPlayer();
            var bassAdvancedTreblePlayer = new BassTrebleAdvancedTitleMusicPlayer();

            var bassMoviePlayer = new BassTrebleMoviePlayer();
            var leftMoviePlayer = new NormalLeftMoviePlayer();

            leftSimpleMusicPlayer.PlaySong(song);
            leftAdvancedMusicPlayer.PlaySong(song);
            bassSimpleTreblePlayer.PlaySong(song);
            bassAdvancedTreblePlayer.PlaySong(song);

            bassMoviePlayer.PlayMovie(movie);
            leftMoviePlayer.PlayMovie(movie);
        }
    }
}
