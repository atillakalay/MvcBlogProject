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
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public List<Author> GetAll()
        {
            return _authorDal.List();
        }

        public Author GetById(int id)
        {
            return _authorDal.Get(x => x.AuthorId == id);
        }

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }
        public void Update(Author author)
        {
            _authorDal.Update(author);

        }

        public void Delete(int id)
        {
            var result = _authorDal.Get(x => x.AuthorId == id);
            _authorDal.Delete(result);
        }

        public Author findAuthor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
