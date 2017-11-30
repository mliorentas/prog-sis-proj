using Autofac;
using System;
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
            builder.REgister
            Container = builder.Build(); 

        }
    }
}
