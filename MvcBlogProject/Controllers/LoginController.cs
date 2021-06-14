using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace MvcBlogProject.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author author)
        {
            EfContext context = new EfContext();
            var userInfo =
                context.Authors.FirstOrDefault(x => x.Email ==
                    author.Email && x.Password == author.Password);
            if (userInfo != null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.Email, false);
                Session["Email"] = userInfo.Email.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }
        }
    }
}