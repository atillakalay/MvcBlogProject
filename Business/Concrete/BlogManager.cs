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
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }


        public List<Blog> GetAll()
        {
            return _blogDal.List();
        }

        public List<Blog> BlogById(int id)
        {
            return _blogDal.List(x => x.BlogId == id);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogDal.List(x => x.AuthorId == id);
        }

        public List<Blog> GetBlogByCategory(int id)
        {
            return _blogDal.List(x => x.CategoryId == id);
        }

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Update(Blog blog)
        {
            Blog result = _blogDal.GetById(x => x.BlogId == blog.BlogId);
            result.BlogTitle = blog.BlogTitle;
            result.BlogContent = blog.BlogContent;
            result.BlogDate = blog.BlogDate;
            result.BlogImage = blog.BlogImage;
            result.CategoryId = blog.CategoryId;
            result.AuthorId = blog.AuthorId;
            _blogDal.Update(result);

        }

        public void Delete(int id)
        {
          var blogId=  _blogDal.Get(x => x.BlogId == id);
          _blogDal.Delete(blogId);
        }

        public Blog FindBlog(int id)
        {
           return _blogDal.Get(x => x.BlogId == id);
        }
    }
}
