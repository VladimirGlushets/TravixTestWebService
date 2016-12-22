using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using TravixTest.DAL;

namespace Epam.TravixTest.DAL.Repositories
{
    /// <summary>
    /// Implementation comment repository
    /// </summary>
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(TravixTestDbContext context) : base(context)
        {
        }
    }
}
