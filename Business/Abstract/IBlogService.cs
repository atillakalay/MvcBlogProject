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
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
    }
}
