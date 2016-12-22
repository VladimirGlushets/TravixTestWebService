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
    public class PostBuisnessService : IPostBuisnessService
    {
        private readonly IPostDomainService _postDomainService;

        public PostBuisnessService(IPostDomainService postDomainService)
        {
            _postDomainService = postDomainService;
        }

        public PostDto Get(int id)
        {
            return Mapper.Map<PostDto>(_postDomainService.Get(id));
        }

        public IEnumerable<PostDto> GetAll()
        {
            return Mapper.Map<IEnumerable<PostBuisnessModel>, IEnumerable<PostDto>>(_postDomainService.GetAll().ToList());
        }

        public async Task Add(PostDto entity)
        {
            var buisnessEntity = Mapper.Map<PostDto, PostBuisnessModel>(entity);

            await _postDomainService.Add(buisnessEntity);
        }

        public async Task Update(PostDto entity)
        {
            var buisnessEntity = Mapper.Map<PostDto, PostBuisnessModel>(entity);

            await _postDomainService.Update(buisnessEntity);
        }

        public async Task Delete(int id)
        {
            await _postDomainService.Delete(id);
        }
    }
}
