using System.Collections.Generic;
using Epam.TravixTest.Buisness.Models.BuisnessModels;
using Epam.TravixTest.Domain.Models;

namespace Epam.TravixTest.Domain.Services.Interfaces.Interfaces
{
    public interface ICommentDomainService : IGenericDomainService<Comment, CommentBuisnessModel>
    {
        IEnumerable<CommentBuisnessModel> FindCommentsBy(int postId);
    }
}
