using Epam.TravixTest.Domain.Models;

namespace TravixTest.DAL.Repositories
{
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(TravixTestDbContext context) : base(context)
        {
        }
    }
}
