using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserProfileService
    {
        List<Author> GetAuthorByEmail(string email);
        List<Blog> GetBlogByAuthor(int id);
        void Update(Author author);
    }
}
