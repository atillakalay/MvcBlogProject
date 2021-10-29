using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> List(Expression<Func<T, bool>> filter);
        T GetById(Expression<Func<T, bool>> filter);
        T GetById(int id);
        List<T> List();
        T Get(Expression<Func<T, bool>> filter);
    }
}
