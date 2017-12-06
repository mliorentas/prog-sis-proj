using Autofac;
using DigitalAudioWorkstation.Domain.Factories.Audio;
using DigitalAudioWorkstation.Domain.Factories.Midi;
using DigitalAudioWorkstation.Domain.Services;
using DigitalAudioWorkstation.Domain.Services.AudioServices;
using DigitalAudioWorkstation.Domain.Services.MidiServices;
using DigitalAudioWorkstation.Repository;

namespace DigitalAudioWorkstation
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            ////Factories
            //builder.RegisterType<AudioDeviceFactory>().As<IDeviceFactory>();
            //builder.RegisterType<AudioEffectsFactory>().As<IEffectFactory>();
            //builder.RegisterType<AudioTrackFactory>().As<ITrackFactory>();

            //Repository
            builder.RegisterType<InMemoryClipStore>().As<IClipStore>();
            builder.RegisterType<InMemoryEffectStore>().As<IEffectStore>();
            builder.RegisterType<InMemoryInputStore>().As<IInputStore>();
            builder.RegisterType<InMemoryInstrumentStore>().As<IInstrumentStore>();
            builder.RegisterType<InMemoryOutputStore>().As<IOutputStore>();
            builder.RegisterType<InMemoryTrackStore>().As<ITrackStore>();

            builder.RegisterType<AudioDeviceService>().As<IDeviceService>();
            builder.RegisterType<AudioEffectService>().As<IEffectService>();
            builder.RegisterType<AudioTrackService>().As<ITrackService>();

            //Different realizations for different classes
            builder.Register(ctx => new AudioTrackService(new AudioTrackFactory()));
            builder.Register(ctx => new AudioEffectService(new AudioEffectsFactory()));
            builder.Register(ctx => new AudioDeviceService(new AudioDeviceFactory()));

            builder.Register(ctx => new MidiTrackService(new MidiTrackFactory()));
            builder.Register(ctx => new MidiEffectService(new MidiInstrumentFactory()));
            builder.Register(ctx => new MidiDeviceService(new MidiDeviceFactory()));

            Container = builder.Build(); 
        }
    }
}
