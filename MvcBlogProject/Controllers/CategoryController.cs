using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

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
    }
}