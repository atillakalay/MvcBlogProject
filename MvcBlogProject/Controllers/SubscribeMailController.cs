using System.Web.Mvc;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace MvcBlogProject.Controllers
{
    [AllowAnonymous]
    public class SubscribeMailController : Controller
    {
      
        private SubscribeMailManager _subscribeMailManager = new SubscribeMailManager(new EfSubscribeMailDal());
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail subscribeMail)
        {
            _subscribeMailManager.Add(subscribeMail);
            return PartialView();
        }
    }
}