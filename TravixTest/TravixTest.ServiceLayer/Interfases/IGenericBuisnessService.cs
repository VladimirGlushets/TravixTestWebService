using System.Collections.Generic;
using System.Threading.Tasks;
using Epam.TravixTest.Buisness.Models.BuisnessModels;
using Epam.TravixTest.Buisness.Models.DtoModels;

namespace Epam.TravixTest.Buisness.Service.Interfases
{
    public interface IGenericBuisnessService<T, TDto> where T : BaseBuisnessModel where TDto : BaseDtoModel
    {
        TDto Get(int id);
        IEnumerable<TDto> GetAll();
        Task Add(TDto entity);
        Task Update(TDto entity);
        Task Delete(int id);
    }
}
