using System.Collections.Generic;
using System.Threading.Tasks;
using Epam.TravixTest.Buisness.Models.BuisnessModels;
using Epam.TravixTest.Buisness.Models.DtoModels;

namespace Epam.TravixTest.Buisness.Service.Interfases
{
    public interface ICommentBuisnessService : IGenericBuisnessService<CommentBuisnessModel, CommentDto>
    {
        IEnumerable<CommentDto> GetAllCommentsBy(int postId);

        Task UpdateComment(CommentDto model);
    }
}
