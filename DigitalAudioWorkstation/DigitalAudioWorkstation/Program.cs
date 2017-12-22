using ArchiMetrics.Analysis;
using ArchiMetrics.Analysis.Common;
using Autofac;
using DigitalAudioWorkstation.Domain.Factories.Audio;
using DigitalAudioWorkstation.Domain.Factories.Midi;
using DigitalAudioWorkstation.Domain.Services;
using DigitalAudioWorkstation.Domain.Services.AudioServices;
using DigitalAudioWorkstation.Domain.Services.MidiServices;
using DigitalAudioWorkstation.Facade;
using DigitalAudioWorkstation.Repository;
using DigitalAudioWorkstation.UI.Controllers;
using DigitalAudioWorkstation.UI.View;
using System;
using System.Linq;
using System.Threading.Tasks;

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
            builder.RegisterType<InMemoryClipStore>().As<IClipStore>().SingleInstance();
            builder.RegisterType<InMemoryEffectStore>().As<IEffectStore>().SingleInstance();
            builder.RegisterType<InMemoryInputStore>().As<IInputStore>().SingleInstance();
            builder.RegisterType<InMemoryInstrumentStore>().As<IInstrumentStore>().SingleInstance();
            builder.RegisterType<InMemoryOutputStore>().As<IOutputStore>().SingleInstance();
            builder.RegisterType<InMemoryTrackStore>().As<ITrackStore>().SingleInstance();

            //Different realizations for different classes
            builder.Register(ctx => new AudioTrackService(new AudioTrackFactory(), ctx.Resolve<ITrackStore>(), ctx.Resolve<IClipStore>())).As<ITrackService>();
            builder.Register(ctx => new AudioEffectService(new AudioEffectsFactory(), ctx.Resolve<IEffectStore>(), ctx.Resolve<IInstrumentStore>())).As<IEffectService>();
            builder.Register(ctx => new AudioDeviceService(new AudioDeviceFactory(), ctx.Resolve<IInputStore>(), ctx.Resolve<IOutputStore>())).As<IDeviceService>();

            //builder.Register(ctx => new MidiTrackService(new MidiTrackFactory(), ctx.Resolve<ITrackStore>(), ctx.Resolve<IClipStore>())).As<ITrackService>();
            //builder.Register(ctx => new MidiEffectService(new MidiInstrumentFactory(), ctx.Resolve<IEffectStore>(), ctx.Resolve<IInstrumentStore>())).As<IEffectService>();
            //builder.Register(ctx => new MidiDeviceService(new MidiDeviceFactory(), ctx.Resolve<IInputStore>(), ctx.Resolve<IOutputStore>())).As<IDeviceService>();

            builder.RegisterType<AudioRecordFacade>().As<IRecordFacade>();
            builder.RegisterType<AudioMixerFacade>().As<IMixerFacade>();

            builder.RegisterType<MixerController>();
            builder.RegisterType<RecordController>();

            builder.Register(ctx => new MainView(ctx.Resolve<MixerController>(), ctx.Resolve<RecordController>()));

            Container = builder.Build();

            var view = Container.Resolve<MainView>();
            var task = RunAnalysis();
            task.Wait();
            view.Main();


        }


        private static async Task RunAnalysis()
        {
            Console.WriteLine("Loading Solution");
            var solutionProvider = new SolutionProvider();
            var solution = await solutionProvider.Get(@"C:\Users\Matas\Desktop\5 Semestras\prog-sis-proj\DigitalAudioWorkstation\DigitalAudioWorkstation.sln");
            Console.WriteLine("Solution loaded");

            var projects = solution.Projects.ToList();

            Console.WriteLine("Loading metrics, wait it may take a while.");
            var metricsCalculator = new CodeMetricsCalculator();
            var calculateTasks = projects.Select(p => metricsCalculator.Calculate(p, solution));
            var metrics = (await Task.WhenAll(calculateTasks)).SelectMany(nm => nm);
            foreach (var metric in metrics)
                Console.WriteLine("Package {0} => A {3}", metric.Name, metric.Abstractness);
        }
    }
}
