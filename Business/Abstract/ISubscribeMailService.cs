using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISubscribeMailService
    {
        List<SubscribeMail> GetAll();
        SubscribeMail GetById(int id);
        void Add(SubscribeMail subscribeMail);
        void Update(SubscribeMail subscribeMail);
        void Delete(int id);
    }
}
