using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Autofac
{

    class Program
    {
        int Count { get; set; }

        static void Main(string[] args)
        {

            var service = ContainerConfig.Configure();

            using (var score = service.BeginLifetimeScope())
            {
                var businessLogic_Autofac = score.Resolve<IBusinessLogic>();

                businessLogic_Autofac.ProcessRun();
            }

            Console.ReadKey();
        }

        
    }
}
