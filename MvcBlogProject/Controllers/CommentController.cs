using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult CommentList()
        {
            return View();
        }

        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }
    }
}