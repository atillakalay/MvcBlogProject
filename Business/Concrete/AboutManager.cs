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
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> GetAll()
        {
            return _aboutDal.List();
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(x => x.AbutId == id);
        }

        public void Add(About about)
        {
            _aboutDal.Add(about);
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);

        }

        public void Delete(int id)
        {
            var aboutId = _aboutDal.Get(x => x.AbutId == id);
            _aboutDal.Delete(aboutId);
        }

        public About FindAbout(int id)
        {
            throw new NotImplementedException();
        }
    }
}
