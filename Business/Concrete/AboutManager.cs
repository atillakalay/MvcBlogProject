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

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public void Update(About about)
        {
            About resultAbout = _aboutDal.GetById(x => x.AbutId == about.AbutId);
            resultAbout.AbutId = about.AbutId;
            resultAbout.AboutImage1 = about.AboutImage1;
            resultAbout.AboutImage2 = about.AboutImage2;
            resultAbout.AboutContent1 = about.AboutContent1;
            resultAbout.AboutContent2 = about.AboutContent2;

            _aboutDal.Update(resultAbout);

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
