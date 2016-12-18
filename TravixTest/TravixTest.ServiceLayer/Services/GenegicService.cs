using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Epam.TravixTest.Domain.Repositories;

namespace TravixTest.ServiceLayer.Services
{
    /// <summary>
    /// Include implementstion for all common methods in every inherit Service
    /// </summary>
    /// <typeparam name="T">Domain model</typeparam>
    /// <typeparam name="TDto">Data Transfer Model (DTO)</typeparam>
    public abstract class GenegicService<T, TDto> : IService<TDto> where T : class where TDto : class
    {
        protected readonly IGenericRepository<T> Repository;

        protected GenegicService(IGenericRepository<T> repository)
        {
            Repository = repository;
        }

        public TDto Get(int id)
        {
            return Mapper.Map<TDto>(Repository.Get(id));
        }

        public IEnumerable<TDto> GetAll()
        {
            return Mapper.Map<IEnumerable<T>, IEnumerable<TDto>>(Repository.GetAll().ToList());
        }

        public async Task Add(TDto dtoEntity)
        {
            var domainEntity = Mapper.Map<TDto, T>(dtoEntity);

            Repository.Add(domainEntity);

            await Repository.SaveAsync();
        }

        public async Task Update(TDto dtoEntity)
        {
            var domainEntity = Mapper.Map<TDto, T>(dtoEntity);

            Repository.Update(domainEntity);

            await Repository.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var domainEntity = Repository.Get(id);

            Repository.Delete(domainEntity);

            await Repository.SaveAsync();
        }
    }
}
