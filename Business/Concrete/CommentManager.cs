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

        public List<Comment> CommentByStatusTrue()
        {
            return _commentDal.List(x => x.CommentStatus == true);
        }

        public List<Comment> CommentByStatusFalse()
        {
            return _commentDal.List(x => x.CommentStatus == false);
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(x => x.CommentId == id);
        }

        public void Add(Comment comment)
        {
            comment.CommentStatus = true;
            _commentDal.Add(comment);
        }

        public void Update(Comment comment)
        {
            Comment result = _commentDal.GetById(x => x.CommentId == comment.CommentId);
            result.CommentStatus = false;
            _commentDal.Update(result);

        }

        public void UpdateToStatusFalse(int id)
        {
            Comment result = _commentDal.GetById(x => x.CommentId == id);
            result.CommentStatus = false;
            _commentDal.Update(result);
        }
        public void UpdateToStatusTrue(int id)
        {
            Comment result = _commentDal.GetById(x => x.CommentId == id);
            result.CommentStatus = true;
            _commentDal.Update(result);
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
