using DemoLibrary;
using System.Reflection;
using System.Linq;

namespace Autofac
{
    class ContainerConfig
    {
        public static IContainer Configure() 
        {
            
            var builder = new ContainerBuilder();

            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(IBusinessLogic)))
                .Where(t => t.Namespace.Contains("Utility"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
