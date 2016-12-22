using Autofac;
using Epam.TravixTest.Buisness.Service.Interfases;
using Epam.TravixTest.Buisness.Service.Services;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    /// <summary>
    /// Register all services for Autofac IoC container
    /// </summary>
    public class BuisnessServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PostBuisnessService>().As<IPostBuisnessService>();
            builder.RegisterType<CommentBuisnessService>().As<ICommentBuisnessService>();
        }
    }
}
