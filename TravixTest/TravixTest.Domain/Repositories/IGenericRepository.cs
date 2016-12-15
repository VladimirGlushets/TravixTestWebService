using System;
using System.Collections.Generic;

namespace Epam.TravixTest.Domain.Repositories
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
