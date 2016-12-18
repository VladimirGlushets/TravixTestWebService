using Epam.TravixTest.Domain.Models;

namespace TravixTest.DAL.Repositories
{
    /// <summary>
    /// Implementstion Post repository
    /// </summary>
    public class PostRepository : GenericRepository<Post>
    {
        public PostRepository(TravixTestDbContext context) : base(context)
        {
        }
    }
}
