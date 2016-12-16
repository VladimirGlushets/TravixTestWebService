using Autofac;
using TravixTest.ServiceLayer.Managers;
using TravixTest.ServiceLayer.Managers.Implementations;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    public class ManagersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenegicManager<,>)).As(typeof(IManager<>));
            builder.RegisterType<PostManager>();
            builder.RegisterType<CommentManager>();
        }
    }
}
