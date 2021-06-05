using System.Linq;
using Business.Concrete;
using System.Web.Mvc;
using DataAccess.Concrete.EntityFramework;
using PagedList;

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

        public PartialViewResult BlogList(int page = 1)
        {
            var result = _blogManager.GetAll().ToPagedList(page, 9);
            return PartialView(result);
        }

        public PartialViewResult FeaturedPosts()
        {
            //1. Post
            var resultTitle = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 1).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 1).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 1).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle1 = resultTitle;
            ViewBag.postImage1 = resultImage;
            ViewBag.postDate1 = resultDate;

            //2. Post
            var resultTitle1 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 2).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage1 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 2).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate1 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 2).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle2 = resultTitle1;
            ViewBag.postImage2 = resultImage1;
            ViewBag.postDate2 = resultDate1;

            //3. Post
            var resultTitle2 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 3).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage2 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 3).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate2 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 3).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle3 = resultTitle2;
            ViewBag.postImage3 = resultImage2;
            ViewBag.postDate3 = resultDate2;

            //4. Post
            var resultTitle3 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 4).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage3 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 4).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate3 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 4).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle4 = resultTitle3;
            ViewBag.postImage4 = resultImage3;
            ViewBag.postDate4 = resultDate3;

            //5. Post
            var resultTitle4 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 5).Select(x => x.BlogTitle).FirstOrDefault();
            var resultImage4 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 5).Select(x => x.BlogImage).FirstOrDefault();
            var resultDate4 = _blogManager.GetAll().OrderByDescending(x => x.BlogId).Where(x => x.CategoryId == 5).Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitle5 = resultTitle4;
            ViewBag.postImage5 = resultImage4;
            ViewBag.postDate5 = resultDate4;

            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        public ActionResult BlogDetails(int id)
        {
            return View();
        }

        public PartialViewResult BlogCover(int id)
        {
            var result = _blogManager.BlogById(id);
            return PartialView(result);
        }
        public PartialViewResult BlogReadAll(int id)
        {
            var result = _blogManager.BlogById(id);
            return PartialView(result);
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}