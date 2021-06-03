using Business.Concrete;
using System.Web.Mvc;
using DataAccess.Concrete.EntityFramework;

namespace MvcBlogProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        private BlogManager _blogManager = new BlogManager(new EfBlogDal());
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList()
        {
            var result = _blogManager.GetAll();
            return PartialView(result);
        }

        public PartialViewResult FeaturedPosts()
        {
            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }

        public ActionResult BlogDetails()
        {
            return View();
        }

        public PartialViewResult BlogCover()
        {
            return PartialView();
        }
        public PartialViewResult BlogReadAll()
        {
            return PartialView();
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}