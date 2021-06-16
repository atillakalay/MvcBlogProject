using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void CategoryStatusFalse(int id);
        void CategoryStatusTrue(int id);
        Category FindCategory(int id);
        Category GetById(int id);
    }
}
