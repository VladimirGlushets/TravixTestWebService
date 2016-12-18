using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Epam.TravixTest.Common.DtoModels;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;

namespace TravixTest.ServiceLayer.Services.Implementations
{
    /// <summary>
    /// Service for comunication between app and DAL. 
    /// Includes all logic for mapping Comment domain models to CommentDto models and revers.
    /// </summary>
    public class CommentService : GenegicService<Comment, CommentDto>
    {
        public CommentService(IGenericRepository<Comment> commentRepository)
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
