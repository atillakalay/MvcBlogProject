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
    public class AuthorController : Controller
    {
        // GET: Author
        private BlogManager _blogManager = new BlogManager(new EfBlogDal());
        private AuthorManager _authorManager = new AuthorManager(new EfAuthorDal());
        [AllowAnonymous]
        public PartialViewResult AuthorAbout(int id)
        {
            var result = _blogManager.BlogById(id);
            return PartialView(result);
        }
        [AllowAnonymous]
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogAuthorId = _blogManager.GetAll().Where(x => x.BlogId == id).Select(x => x.AuthorId)
                .FirstOrDefault();
            var authorBlogs = _blogManager.GetBlogByAuthor(blogAuthorId);
            return PartialView(authorBlogs);
        }

        public ActionResult AuthorList()
        {
            var result = _authorManager.GetAll();
            return View(result);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Author author)
        {
            _authorManager.Add(author);
            return RedirectToAction("AuthorList");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Author author = _authorManager.FindAuthor(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult Update(Author author)
        {
            _authorManager.Update(author);
            return RedirectToAction("AuthorList");
        }
    }
}