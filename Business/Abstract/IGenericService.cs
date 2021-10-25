using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
     
    }
}
