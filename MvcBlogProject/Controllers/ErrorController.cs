using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        public ActionResult Page403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}