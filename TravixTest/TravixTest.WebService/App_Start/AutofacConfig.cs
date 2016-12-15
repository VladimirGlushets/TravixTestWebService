using Autofac;
using Epam.TravixTest.Infrastructure.IoC.Modules;
using Epam.TravixTest.WebService.Controllers;

namespace Epam.TravixTest.WebService
{
    public class AutofacConfig
    {
        public static IContainer Container { get; }

        static AutofacConfig()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<HomeController>().InstancePerRequest();

            builder.RegisterModule(new DbContextModule());
            builder.RegisterModule(new ApiControllersModule());
            builder.RegisterModule(new RepositoriesModule());

            Container = builder.Build();
        }
    }
}