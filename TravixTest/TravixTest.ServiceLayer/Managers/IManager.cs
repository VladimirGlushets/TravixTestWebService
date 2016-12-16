using System.Collections.Generic;
using System.Threading.Tasks;

namespace TravixTest.ServiceLayer.Managers
{
    public interface IManager<TDto> where TDto : class
    {
        TDto Get(int id);
        IEnumerable<TDto> GetAll();
        Task Add(TDto entity);
        Task Update(TDto entity);
        Task Delete(int id);
    }
}
