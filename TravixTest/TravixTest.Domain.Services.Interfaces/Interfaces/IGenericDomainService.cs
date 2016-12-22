using System.Collections.Generic;
using System.Threading.Tasks;
using Epam.TravixTest.Buisness.Models.BuisnessModels;
using Epam.TravixTest.Domain.Models;

namespace Epam.TravixTest.Domain.Services.Interfaces.Interfaces
{
    public interface IGenericDomainService<T, TBto> where T : BaseDomainEntity where TBto : BaseBuisnessModel
    {
        TBto Get(int id);
        IEnumerable<TBto> GetAll();
        Task Add(TBto entity);
        Task Update(TBto entity);
        Task Delete(int id);
    }
}
