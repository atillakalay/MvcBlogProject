using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        int Add(Category category);
        int Update(Category category);
        int Delete(Category category);
        Category GetById(int id);
    }
}
