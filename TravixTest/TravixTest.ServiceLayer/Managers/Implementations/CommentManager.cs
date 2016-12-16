using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Epam.TravixTest.Common.DtoModels;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;

namespace TravixTest.ServiceLayer.Managers.Implementations
{
    public class CommentManager : GenegicManager<Comment, CommentDto>
    {
        public CommentManager(IGenericRepository<Comment> commentRepository)
            : base(commentRepository)
        {
        }

        public IEnumerable<CommentDto> GetAllCommentsBy(int postId)
        {
            return Mapper.Map<IEnumerable<Comment>, IEnumerable<CommentDto>>(Repository.FindCommentsBy(x => x.PostId == postId).ToList());
        }

        public async Task UpdateComment(CommentDto model)
        {
            var domainComment = Repository.FindFirstOrDefault(x => x.Id == model.Id);

            UpdateDomainModel(domainComment, model);

            Repository.Update(domainComment);

            await Repository.SaveAsync();
        }

        private void UpdateDomainModel(Comment commentDomain, CommentDto commentDto)
        {
            commentDomain.Content = commentDto.Content;
            commentDomain.LastUpdatedDate = commentDto.LastUpdatedDate;
        }
    }
}
