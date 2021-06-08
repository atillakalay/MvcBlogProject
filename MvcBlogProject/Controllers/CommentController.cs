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
    public class CommentController : Controller
    {
        // GET: Comment
        private CommentManager _commentManager = new CommentManager(new EfCommentDal());
        public PartialViewResult CommentList(int id)
        {
            var result = _commentManager.CommentByBlog(id);
            return PartialView(result);
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment comment)
        {
            _commentManager.Add(comment);
            return PartialView();
        }

        public ActionResult AdminCommentListTrue()
        {
            var result = _commentManager.CommentByStatusTrue();
            return View(result);
        }
        public ActionResult AdminCommentListFalse()
        {
            var result = _commentManager.CommentByStatusFalse();
            return View(result);
        }

        public ActionResult StatusChangeToFalse(int id)
        {
            _commentManager.UpdateToStatusFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }
        public ActionResult StatusChangeToTrue(int id)
        {
            _commentManager.UpdateToStatusTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }
    }
}