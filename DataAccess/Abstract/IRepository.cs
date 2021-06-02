using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        T GetById(int id);

    }
}
