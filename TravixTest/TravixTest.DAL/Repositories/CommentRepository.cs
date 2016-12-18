using Epam.TravixTest.Domain.Models;

namespace TravixTest.DAL.Repositories
{
    /// <summary>
    /// Implementation comment repository
    /// </summary>
    public class CommentRepository : GenericRepository<Comment>
    {
        public CommentRepository(TravixTestDbContext context) : base(context)
        {
        }
    }
}
