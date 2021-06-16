using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.List();
        }

        public void Add(Category category)
        {
            category.CategoryStatus = true;
            _categoryDal.Add(category);
        }
        public void Update(Category category)
        {
            Category result = _categoryDal.GetById(x => x.CategoryId == category.CategoryId);
            result.CategoryName = category.CategoryName;
            result.CategoryDescription = category.CategoryDescription;
            _categoryDal.Update(result);

        }

        public void CategoryStatusFalse(int id)
        {
            Category category = _categoryDal.Get(x => x.CategoryId == id);
            category.CategoryStatus = false;
            _categoryDal.Update(category);
        }

        public void CategoryStatusTrue(int id)
        {
            Category category = _categoryDal.Get(x => x.CategoryId == id);
            category.CategoryStatus = true;
            _categoryDal.Update(category);
        }

        public Category FindCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }
    }
}
