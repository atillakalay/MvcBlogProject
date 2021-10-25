using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICommentsService:IGenericService<Comment>
    {
        List<Comment> CommentByStatusTrue();
        List<Comment> CommentByStatusFalse();
        void UpdateToStatusFalse(int id);
        void UpdateToStatusTrue(int id);
        Comment FindComment(int id);
        List<Comment> CommentByBlog(int id);
        List<Comment> CommentByStatusTrueAndBlogId(int id);
        List<Comment> CommentByStatusFalseAndBlogId(int id);
    }
}
