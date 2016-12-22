using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Epam.TravixTest.Buisness.Models.BuisnessModels;
using Epam.TravixTest.Domain.Models;
using Epam.TravixTest.Domain.Repositories;
using Epam.TravixTest.Domain.Services.Interfaces.Interfaces;

namespace TravixTest.Domain.Services.Services
{
    public class CommentDomainService : GenericDomainService<Comment, CommentBuisnessModel>, ICommentDomainService
    {
        public CommentDomainService(ICommentRepository repository) : base(repository)
        {
        }

        public IEnumerable<CommentBuisnessModel> FindCommentsBy(int postId)
        {
            return Mapper.Map<IQueryable<Comment>, IEnumerable<CommentBuisnessModel>>(Repository.FindCommentsBy(x => x.PostId == postId));
        }

        public override async Task Update(CommentBuisnessModel entity)
        {
            var domainComment = Repository.FindFirstOrDefault(x => x.Id == entity.Id);

            UpdateDomainModel(domainComment, entity);

            Repository.Update(domainComment);

            await Repository.SaveAsync();
        }

        private void UpdateDomainModel(Comment commentDomain, CommentBuisnessModel commentDto)
        {
            commentDomain.Content = commentDto.Content;
            commentDomain.LastUpdatedDate = commentDto.LastUpdatedDate;
        }
    }
}
