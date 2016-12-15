using Epam.TravixTest.Domain.Models;

namespace TravixTest.DAL.Repositories
{
    public class PostRepository : GenericRepository<Post>
    {
        public PostRepository(TravixTestDbContext context) : base(context)
        {
        }
    }
}
