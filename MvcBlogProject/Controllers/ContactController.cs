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
    public class ContactController : Controller
    {
        // GET: Contact
        private ContactManager _contactManager = new ContactManager(new EfContactDal());
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Contact contact)
        {
            _contactManager.Add(contact);
            return View();
        }

        public ActionResult InBox()
        {
            var result = _contactManager.GetAll();
            return View(result);
        }
        public ActionResult SendBox()
        {
            var result = _contactManager.GetAll();
            return View(result);
        }

        public ActionResult MessageDetails(int id)
        {
            Contact contact = _contactManager.GetById(id);
            return View(contact);
        }
    }
}