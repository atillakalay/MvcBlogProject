using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> BlogById(int id);
        List<Blog> GetBlogByAuthor(int id);
        List<Blog> GetBlogByCategory(int id);
        Blog FindBlog(int id);
    }
}
