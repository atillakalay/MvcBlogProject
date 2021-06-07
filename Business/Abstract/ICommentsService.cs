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
        Comment GetById(int id);
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(int id);
        Comment FindComment(int id);
        List<Comment> CommentByBlog(int id);
    }
}
