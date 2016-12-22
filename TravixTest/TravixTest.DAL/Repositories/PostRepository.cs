using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using TravixTest.DAL;

namespace Epam.TravixTest.DAL.Repositories
{
    /// <summary>
    /// Implementstion Post repository
    /// </summary>
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(TravixTestDbContext context) : base(context)
        {
        }
    }
}
