using Autofac;
using TravixTest.DAL;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    /// <summary>
    /// Register all db contexts for Autofac IoC container
    /// </summary>
    public class DbContextModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TravixTestDbContext>().InstancePerRequest();
        }
    }
}
