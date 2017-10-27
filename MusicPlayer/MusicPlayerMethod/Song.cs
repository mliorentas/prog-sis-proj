namespace MusicPlayerMethod
{
    public class Song : IMedia
    {        
        public float Compression {get;}
        public string Title { get; }
        public string Artist { get; }
        public string Album { get; }

        public Song (string title, string artist, string album, float compression)
        {
            Compression = compression;
            Title = title;
            Artist = artist;
            Album = album;
        }
    }
}