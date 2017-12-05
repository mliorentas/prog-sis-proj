using Autofac;
using DigitalAudioWorkstation.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAudioWorkstation
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            // Usually you're only interested in exposing the type
            // via its interface:
            //builder.RegisterType<SomeType>().As<IService>();

            // However, if you want BOTH services (not as common)
            // you can say so:
            //builder.RegisterType<SomeType>().AsSelf().As<IService>();

            //builder.RegisterType<ConsoleOutput>().As<IOutput>();
            //builder.RegisterType<TodayWriter>().As<IDateWriter>();
            builder.RegisterType<AudioDeviceFactory>().As<IDeviceFactory>();
            builder.RegisterType<AudioEffectsFactory>().As<IEffectFactory>();
            builder.RegisterType<AudioTrackFactory>().As<ITrackFactory>();

            builder.RegisterType<InMemoryClipStore>().As<IClipStore>();
            builder.RegisterType<InMemoryEffectStore>().As<IEffectStore>();
            builder.RegisterType<InMemoryInputStore>().As<IInputStore>();
            builder.RegisterType<InMemoryInstrumentStore>().As<IInstrumentStore>();
            builder.RegisterType<InMemoryOutputStore>().As<IOutputStore>();
            builder.RegisterType<InMemoryTrackStore>().As<ITrackStore>();

            Container = builder.Build(); 

        }
    }
}
