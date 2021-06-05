using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace MvcBlogProject.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        private CommentManager _commentManager = new CommentManager(new EfCommentDal());
        public PartialViewResult CommentList(int id)
        {
            var result = _commentManager.CommentByBlog(id);
            return PartialView(result);
        }

        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }
    }
}