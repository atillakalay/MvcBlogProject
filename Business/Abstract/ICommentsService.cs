using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICommentsService
    {
        List<Comment> GetAll();
        List<Comment> CommentByStatusTrue();
        List<Comment> CommentByStatusFalse();
        Comment GetById(int id);
        void Add(Comment comment);
        void Update(Comment comment);
        void UpdateToStatusFalse(int id);
        void UpdateToStatusTrue(int id);
        void Delete(int id);
        Comment FindComment(int id);
        List<Comment> CommentByBlog(int id);

        List<Comment> CommentByStatusTrueAndBlogId(int id);
        List<Comment> CommentByStatusFalseAndBlogId(int id);
    }
}
