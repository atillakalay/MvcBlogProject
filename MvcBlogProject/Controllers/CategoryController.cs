using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace MvcBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private CategoryManager _categoryManager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult BlogDetailsCategoryList()
        {
            var result = _categoryManager.GetAll();
            return PartialView(result);
        }

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
            _categoryManager.Add(category);
            return RedirectToAction("AdminCategoryList");
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
            _categoryManager.Update(category);
            return RedirectToAction("AdminCategoryList");
        }
    }
}