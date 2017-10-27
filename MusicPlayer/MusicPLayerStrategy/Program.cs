using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPLayerStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var song = new Song("My Heart Will Go On", "Celine Dion", "Let's Talk About Love", 0.42f);
            var movie = new Movie("Titanic", 0.1f);

            var bassMoviePlayer = new MoviePlayer(new BassTrebleEqualizer());
            var leftMoviePlayer = new MoviePlayer(new NormalLeftEqualizer());

            var leftSimpleMusicPlayer = new MusicPlayer(new NormalLeftEqualizer(), new SimpleFormatter());
            var leftAdvancedMusicPlayer = new MusicPlayer(new NormalLeftEqualizer(), new AdvancedTitleFormatter());
            var bassSimpleTreblePlayer = new MusicPlayer(new BassTrebleEqualizer(), new SimpleFormatter());
            var bassAdvancedTreblePlayer = new MusicPlayer(new BassTrebleEqualizer(), new AdvancedTitleFormatter());

            leftSimpleMusicPlayer.PlaySong(song);
            leftAdvancedMusicPlayer.PlaySong(song);
            bassSimpleTreblePlayer.PlaySong(song);
            bassAdvancedTreblePlayer.PlaySong(song);

            bassMoviePlayer.PlayMovie(movie);
            leftMoviePlayer.PlayMovie(movie);
        }
    }
}
