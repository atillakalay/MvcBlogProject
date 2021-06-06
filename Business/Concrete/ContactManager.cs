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
    public class ContactManager : IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetAll()
        {
            return _contactDal.List();
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.ContactId == id);
        }

        public void Add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }
    }
}
