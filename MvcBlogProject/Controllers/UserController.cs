using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace MvcBlogProject.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private UserProfileManager _userProfileManager = new UserProfileManager(new EfAuthorDal());
        private UserProfileManager userProfileManagerByBlog = new UserProfileManager(new EfBlogDal());
        private BlogManager _blogManager = new BlogManager(new EfBlogDal());
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1(string email)
        {
            var result = (string)Session["Email"];
            email = result;
            var results = _userProfileManager.GetAuthorByEmail(email);
            return PartialView(results);
        }

        public ActionResult BlogList(string email)
        {
            EfContext efContext = new EfContext();
            email = (string)Session["Email"];
            int id = efContext.Authors.Where(x => x.Email == email).Select(y => y.AuthorId).FirstOrDefault();
            var results = userProfileManagerByBlog.GetBlogByAuthor(id);
            return View(results);
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = _blogManager.FindBlog(id);
            EfContext efContext = new EfContext();
            List<SelectListItem> valuesCategory = (from x in efContext.Categories.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.valuesCategory = valuesCategory;

            List<SelectListItem> valuesAuthor = (from x in efContext.Authors.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.AuthorName,
                                                     Value = x.AuthorId.ToString()
                                                 }).ToList();
            ViewBag.valuesAuthor = valuesAuthor;
            return View(blog);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            _blogManager.Update(blog);
            return RedirectToAction("BlogList");
        }
        [HttpGet]
        public ActionResult AddNewBlog()
        {
            EfContext efContext = new EfContext();
            List<SelectListItem> valuesCategory = (from x in efContext.Categories.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
            ViewBag.valuesCategory = valuesCategory;

            List<SelectListItem> valuesAuthor = (from x in efContext.Authors.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.AuthorName,
                                                     Value = x.AuthorId.ToString()
                                                 }).ToList();
            ViewBag.valuesAuthor = valuesAuthor;

            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog blog)
        {
            _blogManager.Add(blog);
            return RedirectToAction("BlogList");
        }

        public ActionResult UpdateUserProfile(Author author)
        {
            _userProfileManager.Update(author);
            return RedirectToAction("Index");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AuthorLogin", "Login");
        }
    }
}