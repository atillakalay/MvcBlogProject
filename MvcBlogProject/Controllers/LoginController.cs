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
    [AllowAnonymous]
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

        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            EfContext context = new EfContext();
            var adminInfo =
                context.Admins.FirstOrDefault(x => x.UserName ==
                    admin.UserName && x.Password == admin.Password);
            if (adminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminInfo.UserName, false);
                Session["UserName"] = adminInfo.UserName.ToString();
                return RedirectToAction("AdminBlogList", "Blog");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }
        }
    }
}