using System.Web.Mvc;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;

namespace MvcBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult BlogDetailsCategoryList()
        {
            var result = _categoryManager.GetAll();
            return PartialView(result);
        }
        [HttpGet]
        public ActionResult AdminCategoryList()
        {
            var result = _categoryManager.GetAll();
            return View(result);
        }
        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminCategoryAdd(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);
            if (result.IsValid)
            {
                _categoryManager.Add(category);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach (var resultError in result.Errors)
                {
                    ModelState.AddModelError(resultError.PropertyName, resultError.ErrorMessage);
                }
            }
            return View();

        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Category category = _categoryManager.GetById(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Update(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);
            if (result.IsValid)
            {
                _categoryManager.Update(category);
                return RedirectToAction("AdminCategoryList");
            }
            else
            {
                foreach (var resultError in result.Errors)
                {
                    ModelState.AddModelError(resultError.PropertyName, resultError.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult CategoryStatusTrue(int id)
        {
            _categoryManager.CategoryStatusTrue(id);
            return RedirectToAction("AdminCategoryList");
        }
        public ActionResult CategoryStatusFalse(int id)
        {
            _categoryManager.CategoryStatusFalse(id);
            return RedirectToAction("AdminCategoryList");
        }
    }

}