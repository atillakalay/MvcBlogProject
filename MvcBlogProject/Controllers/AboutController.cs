using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace MvcBlogProject.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager _aboutManager = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Footer()
        {
            var result = _aboutManager.GetAll();
            return PartialView(result);
        }
        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
    }
}