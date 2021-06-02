using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private EfContext efContext = new EfContext();
        private DbSet<T> _dbSet;

        public Repository(DbSet<T> dbSet)
        {
            _dbSet = dbSet;
        }

        public int Add(T entity)
        {
            _dbSet.Add(entity);
            return efContext.SaveChanges();
        }

        public int Delete(T entity)
        {
            _dbSet.Remove(entity);
            return efContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> List()
        {
            return _dbSet.ToList();
        }

        public int Update(T entity)
        {
            return efContext.SaveChanges();
        }
    }
}
