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
        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            var result = _commentManager.CommentByBlog(id);
            return PartialView(result);
        }
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [AllowAnonymous]
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
        public ActionResult AuthorCommentListTrue(string email)
        {
            EfContext efContext = new EfContext();
            email = (string)Session["Email"];
            int id = efContext.Authors.Where(x => x.Email == email).Select(y => y.AuthorId).FirstOrDefault();
            var result = _commentManager.CommentByStatusTrueAndBlogId(id);
            return View(result);
        }
        public ActionResult AuthorCommentListFalse(string email)
        {
            EfContext efContext = new EfContext();
            email = (string)Session["Email"];
            int id = efContext.Authors.Where(x => x.Email == email).Select(y => y.AuthorId).FirstOrDefault();
            var result = _commentManager.CommentByStatusFalseAndBlogId(id);
            return View(result);
        }
        public ActionResult StatusChangeToFalseByAuthor(int id)
        {
            _commentManager.UpdateToStatusFalse(id);
            return RedirectToAction("AuthorCommentListTrue");
        }
        public ActionResult StatusChangeToTrueByAuthor(int id)
        {
            _commentManager.UpdateToStatusTrue(id);
            return RedirectToAction("AuthorCommentListFalse");
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