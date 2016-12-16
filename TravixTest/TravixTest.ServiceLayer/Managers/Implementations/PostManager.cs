using Epam.TravixTest.Common.DtoModels;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;

namespace TravixTest.ServiceLayer.Managers.Implementations
{
    public class PostManager : GenegicManager<Post, PostDto>
    {
        public PostManager(IGenericRepository<Post> postRepository)
            : base(postRepository)
        {
        }
    }
}
