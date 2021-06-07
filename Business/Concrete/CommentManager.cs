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
    public class CommentManager : ICommentsService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetAll()
        {
            return _commentDal.List();
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(x => x.CommentId == id);
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);

        }

        public void Delete(int id)
        {
            var blogId = _commentDal.Get(x => x.BlogId == id);
            _commentDal.Delete(blogId);
        }

        public Comment FindComment(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> CommentByBlog(int id)
        {
            return _commentDal.List(x => x.BlogId == id);
        }
    }
}
