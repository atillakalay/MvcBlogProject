using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        T GetById(int id);

    }
}
