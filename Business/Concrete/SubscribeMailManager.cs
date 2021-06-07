using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SubscribeMailManager : ISubscribeMailService
    {
        private ISubscribeMailDal _subscribeMailDal;

        public SubscribeMailManager(ISubscribeMailDal subscribeMailDal)
        {
            _subscribeMailDal = subscribeMailDal;
        }

        public List<SubscribeMail> GetAll()
        {
            return _subscribeMailDal.List();
        }

        public SubscribeMail GetById(int id)
        {
            return _subscribeMailDal.Get(x => x.MailId == id);
        }

        public void Add(SubscribeMail subscribeMail)
        {
            _subscribeMailDal.Add(subscribeMail);
        }

        public void Update(SubscribeMail subscribeMail)
        {
            _subscribeMailDal.Update(subscribeMail);

        }

        public void Delete(int id)
        {
            var mailId = _subscribeMailDal.Get(x => x.MailId == id);
            _subscribeMailDal.Delete(mailId);
        }
    }
}
