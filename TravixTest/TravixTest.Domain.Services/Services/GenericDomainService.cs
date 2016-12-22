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
    public abstract class GenericDomainService <T, TBto> : IGenericDomainService<T, TBto> where T : BaseDomainEntity where TBto : BaseBuisnessModel
    {
        protected readonly IGenericRepository<T> Repository;

        protected GenericDomainService(IGenericRepository<T> repository)
        {
            Repository = repository;
        }

        public TBto Get(int id)
        {
            return Mapper.Map<TBto>(Repository.Get(id));
        }

        public IEnumerable<TBto> GetAll()
        {
            return Mapper.Map<IEnumerable<T>, IEnumerable<TBto>>(Repository.GetAll().ToList());
        }

        public async Task Add(TBto entity)
        {
            var domainEntity = Mapper.Map<TBto, T>(entity);

            Repository.Add(domainEntity);

            await Repository.SaveAsync();
        }

        public virtual async Task Update(TBto entity)
        {
            var domainEntity = Mapper.Map<TBto, T>(entity);

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
