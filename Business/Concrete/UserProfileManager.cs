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
    public class UserProfileManager : IUserProfileService
    {
        private IAuthorDal _authorDal;
        private IBlogDal _blogDal;

        public UserProfileManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;

        }
        public UserProfileManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Author> GetAuthorByEmail(string email)
        {
            return _authorDal.List(x => x.Email == email);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogDal.List(x => x.AuthorId == id);
        }

        public void Update(Author author)
        {
            Author result = _authorDal.Get(x => x.AuthorId == author.AuthorId);
            result.AboutShort = author.AboutShort;
            result.AuthorName = author.AuthorName;
            result.AuthorAbout = author.AuthorAbout;
            result.AuthorJob = author.AuthorJob;
            result.Email = author.Email;
            result.Password = author.Password;
            result.PhoneNumber = author.PhoneNumber;
            _authorDal.Update(result);


        }
    }
}
