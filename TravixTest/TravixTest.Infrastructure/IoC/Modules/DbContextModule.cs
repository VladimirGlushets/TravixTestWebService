using Autofac;
using TravixTest.DAL;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    public class DbContextModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TravixTestDbContext>().InstancePerRequest();
        }
    }
}
