using DigitalAudioWorkstation.UI.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAudioWorkstation.Entities;

namespace DigitalAudioWorkstation.UI.View
{
    class MainView
    {
        MixerController m_mixer;
        RecordController m_recorder;

        public MainView(MixerController mixer, RecordController recorder)
        {
            m_mixer = mixer;
            m_recorder = recorder;
        }
        public int Start()
        {
            int number = -1;
            while (number > 7 || number < 0)
            {
                Console.WriteLine("Enter 1 to create Input.");
                Console.WriteLine("Enter 2 to create Output.");
                Console.WriteLine("Enter 3 to create Effect.");
                Console.WriteLine("Enter 4 to create Instrument.");
                Console.WriteLine("Enter 5 to create Track.");
                Console.WriteLine("Enter 6 to record Clip.");
                Console.WriteLine("Enter 7 to Play Track.");

                Console.WriteLine("Enter 0 to exit.");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format is incorrect.");
                }
                catch (IOException)
                {
                    Console.WriteLine("Failed reading from input.");
                }
            }

            return number;
        }

        public void Main()
        {
            while(true)
            {
                var choice = Start();
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Input input id.");
                        var inputId = Console.ReadLine();
                        ShowInput(m_recorder.CreateInput(inputId));
                        break;
                    case 2:
                        Console.WriteLine("Input output id.");
                        var outputId = Console.ReadLine();
                        ShowOutput(m_mixer.CreateOutput(outputId));
                        break;
                    case 3:
                        Console.WriteLine("Input effect id.");
                        var effectId = Console.ReadLine();

                        ShowEffect(m_mixer.CreateEffect(effectId));
                        break;
                    case 4:
                        Console.WriteLine("Input instrument id.");
                        var instrumentId = Console.ReadLine();

                        ShowInstrument(m_recorder.CreateInstrument(instrumentId));
                        break;
                    case 5:
                        Console.WriteLine("Input track id.");
                        var trackId = Console.ReadLine();
                        ShowTrack(m_recorder.CreateTrack(trackId));
                        break;
                    case 6:
                        Console.WriteLine("Input track id.");
                        var track = Console.ReadLine();
                        Console.WriteLine("Input instrument id.");
                        var instrument = Console.ReadLine();
                        Console.WriteLine("Input input id.");
                        var input = Console.ReadLine();
                        Console.WriteLine("Input clip id.");
                        var clipId = Console.ReadLine();
                        ShowClip(m_recorder.RecordClip(clipId, track, instrument, input));
                        break;
                    case 7:
                        Console.WriteLine("Input track id.");
                        var trakk = Console.ReadLine();
                        Console.WriteLine("Input output id.");
                        var output = Console.ReadLine();
                        Console.WriteLine("Input effect id.");
                        var effect = Console.ReadLine();
                        ShowSong(m_mixer.PlayTrack(trakk, output, effect));
                        break;
                }
            }

        }

        private void ShowSong(string song)
        {
            Console.WriteLine("Played song - ", song);
        }

        private void ShowClip(IClip clip)
        {
            Console.WriteLine("Created clip with id - {0}, data - {1}.", clip.Id, clip.Data);
        }

        private void ShowTrack(ITrack track)
        {
            Console.WriteLine("Created track with id - {0}, info - {1}.", track.Id, track.TrackInfo);
        }

        private void ShowInstrument(IInstrument instrument)
        {
            Console.WriteLine("Created instrument with id - {0}, info - {1}.", instrument.Id, instrument.InstrumentInfo);
        }

        private void ShowEffect(IEffect effect)
        {
            Console.WriteLine("Created effect with id - {0}, info - {1}.", effect.Id, effect.Effect);
        }

        private void ShowOutput(IOutput output)
        {
            Console.WriteLine("Created output with id - {0}, type - {1}.", output.Id, output.OutputType);
        }

        private void ShowInput(IInput input)
        {
            Console.WriteLine("Created input with id - {0}, type - {1}.", input.Id, input.InputType);
        }
    }
}
