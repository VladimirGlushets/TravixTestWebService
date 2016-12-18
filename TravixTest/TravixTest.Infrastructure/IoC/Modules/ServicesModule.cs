using Autofac;
using TravixTest.ServiceLayer.Services;
using TravixTest.ServiceLayer.Services.Implementations;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    /// <summary>
    /// Register all services for Autofac IoC container
    /// </summary>
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenegicService<,>)).As(typeof(IService<>));
            builder.RegisterType<PostService>();
            builder.RegisterType<CommentService>();
        }
    }
}
