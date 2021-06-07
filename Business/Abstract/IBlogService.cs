using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        List<Blog> BlogById(int id);
        List<Blog> GetBlogByAuthor(int id);
        List<Blog> GetBlogByCategory(int id);
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(int id);
        Blog FindBlog(int id);
    }
}
