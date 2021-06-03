using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetById(int id);
    }
}
