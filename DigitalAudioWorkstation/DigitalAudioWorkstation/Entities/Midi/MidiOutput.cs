using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation.Entities.Midi
{
    class MidiOutput : IOutput
    {
        public string Id { get; set; }
        public string OutputType { get; set; }
    }
}
