using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Footer()
        {
            return PartialView();
        }
        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
    }
}