using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerMethod
{
    public interface IMedia
    {
        float Compression { get; }
        string Title { get; }
    }
}
