using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Epam.TravixTest.Domain.Repositories
{
    /// <summary>
    /// Interface IGenericRepository inludes all common methods for all inherits entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
        Task SaveAsync();
        IQueryable<T> FindCommentsBy(Expression<Func<T, bool>> predicate);
        T FindFirstOrDefault(Expression<Func<T, bool>> predicate);
    }
}
