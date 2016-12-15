using System;
using System.Collections.Generic;
using System.Data.Entity;
using Epam.TravixTest.Domain.Repositories;

namespace TravixTest.DAL.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T:class{

        protected TravixTestDbContext Db;
        protected readonly DbSet<T> Set;

        protected GenericRepository(TravixTestDbContext context)
        {
            Db = context;
            Set = Db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            var query = Set;
            return query;
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
