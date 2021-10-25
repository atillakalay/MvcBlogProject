using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
   public interface ICategoryService:IGenericService<Category>
    {
        void CategoryStatusFalse(int id);
        void CategoryStatusTrue(int id);
        Category FindCategory(int id);
    }
}
