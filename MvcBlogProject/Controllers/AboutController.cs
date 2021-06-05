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
        private AuthorManager _authorManager = new AuthorManager(new EfAuthorDal());
        public ActionResult Index()
        {
            var aboutContent = _aboutManager.GetAll();
            return View(aboutContent);
        }

        public PartialViewResult Footer()
        {
            var result = _aboutManager.GetAll();
            return PartialView(result);
        }
        public PartialViewResult MeetTheTeam()
        {
            var result = _authorManager.GetAll();
            return PartialView(result);
        }
    }
}