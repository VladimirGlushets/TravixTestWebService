using Autofac;
using Epam.TravixTest.Domain.Services.Interfaces.Interfaces;
using TravixTest.Domain.Services.Services;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    public class DomainServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericDomainService<,>)).As(typeof(IGenericDomainService<,>)); 
            builder.RegisterType<PostDomainService>().As<IPostDomainService>();
            builder.RegisterType<CommentDomainService>().As<ICommentDomainService>();
        }
    }
}
