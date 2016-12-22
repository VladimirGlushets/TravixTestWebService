using Autofac;
using Epam.TravixTest.DAL.Repositories;
using Epam.TravixTest.Domain.Repositories;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    /// <summary>
    /// Register all repositories for Autofac IoC container
    /// </summary>
    public class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterType<PostRepository>().As<IPostRepository>();
            builder.RegisterType<CommentRepository>().As<ICommentRepository>();
        }
    }
}
