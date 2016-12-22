using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Epam.TravixTest.Buisness.Models.BuisnessModels;
using Epam.TravixTest.Buisness.Models.DtoModels;
using Epam.TravixTest.Buisness.Service.Interfases;
using Epam.TravixTest.Domain.Services.Interfaces.Interfaces;

namespace Epam.TravixTest.Buisness.Service.Services
{
    public class CommentBuisnessService : ICommentBuisnessService
    {
        private readonly ICommentDomainService _commentDomainService;

        public CommentBuisnessService(ICommentDomainService commentDomainService)
        {
            _commentDomainService = commentDomainService;
        }


        public CommentDto Get(int id)
        {
            return Mapper.Map<CommentDto>(_commentDomainService.Get(id));
        }

        public IEnumerable<CommentDto> GetAll()
        {
            return Mapper.Map<IEnumerable<CommentBuisnessModel>, IEnumerable<CommentDto>>(_commentDomainService.GetAll().ToList());
        }

        public async Task Add(CommentDto entity)
        {
            var buisnessEntity = Mapper.Map<CommentDto, CommentBuisnessModel>(entity);

            await _commentDomainService.Add(buisnessEntity);
        }

        public async Task Update(CommentDto entity)
        {
            var buisnessEntity = Mapper.Map<CommentDto, CommentBuisnessModel>(entity);

            await _commentDomainService.Update(buisnessEntity);
        }

        public async Task Delete(int id)
        {
            await _commentDomainService.Delete(id);
        }

        public IEnumerable<CommentDto> GetAllCommentsBy(int postId)
        {
            return Mapper.Map<IEnumerable<CommentBuisnessModel>, IEnumerable<CommentDto>>(_commentDomainService.FindCommentsBy(postId));
        }

        public async Task UpdateComment(CommentDto model)
        {
            var buisnessEntity = Mapper.Map<CommentBuisnessModel>(model);

            await _commentDomainService.Update(buisnessEntity);
        }
    }
}
