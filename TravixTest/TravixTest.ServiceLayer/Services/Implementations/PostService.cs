using Epam.TravixTest.Common.DtoModels;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;

namespace TravixTest.ServiceLayer.Services.Implementations
{
    /// <summary>
    /// Service for comunication between app and DAL. 
    /// Includes all logic for mapping Post domain models to PostDto models and revers.
    /// </summary>
    public class PostService : GenegicService<Post, PostDto>
    {
        public PostService(IGenericRepository<Post> postRepository)
            : base(postRepository)
        {
        }
    }
}
