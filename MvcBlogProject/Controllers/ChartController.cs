using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using MvcBlogProject.Models;

namespace MvcBlogProject.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizeResult()
        {
            return Json(BlogList(),JsonRequestBehavior.AllowGet);
        }
        public List<BlogsRatings> BlogList()
        {
            List<BlogsRatings> cs = new List<BlogsRatings>();
            using (var item =new EfContext())
            {
                cs = item.Blogs.Select(x => new BlogsRatings
                {
                    BlogName = x.BlogTitle,
                    Rating = x.BlogRating
                }).ToList();
            }
            return cs;
        }


    }
}