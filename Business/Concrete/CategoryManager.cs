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
            _categoryDal.Add(category);
        }
        public void Update(Category category)
        {
            Category result = _categoryDal.GetById(x => x.CategoryId == category.CategoryId);
            result.CategoryName = category.CategoryName;
            result.CategoryDescription = category.CategoryDescription;
            _categoryDal.Update(result);

        }

        public void Delete(int id)
        {
            var result = _categoryDal.Get(x => x.CategoryId == id);
            _categoryDal.Delete(result);
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
