using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    class Movie : IMedia
    {
        public float Compression { get; }
        public string Title { get; }

        public Movie (string title, float compression)
        {
            Title = title;
            Compression = compression;
        }
    }
}
