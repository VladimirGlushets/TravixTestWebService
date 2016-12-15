using Autofac;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using TravixTest.DAL.Repositories;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    public class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<PostRepository>().As<IGenericRepository<Post>>();
            builder.RegisterType<CommentRepository>().As<IGenericRepository<Comment>>();
        }
    }
}
