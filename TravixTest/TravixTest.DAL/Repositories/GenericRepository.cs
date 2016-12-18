using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Epam.TravixTest.Domain.Repositories;

namespace TravixTest.DAL.Repositories
{
    /// <summary>
    /// GenericRepository include implementstion for all common methods in every inherit repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected TravixTestDbContext Db;
        protected readonly DbSet<T> Set;

        protected GenericRepository(TravixTestDbContext context)
        {
            Db = context;
            Set = Db.Set<T>();
        }

        public T Get(int id)
        {
            return Set.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            var query = Set;
            return query;
        }

        public IQueryable<T> FindCommentsBy(Expression<Func<T, bool>> predicate)
        {
            return Set.Where(predicate);
        }

        public T FindFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Set.FirstOrDefault(predicate);
        }

        public virtual void Add(T entity)
        {
            Set.Add(entity);
        }

        public virtual void Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            Set.Remove(entity);
        }

        public void Save()
        {
            Db.SaveChanges();
        }

        public Task SaveAsync()
        {
            return Db.SaveChangesAsync();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Db != null)
                {
                    Db.Dispose();
                    Db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
