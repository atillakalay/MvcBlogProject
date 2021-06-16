using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int BlogId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(300)]
        public string CommentText { get; set; }
        public int BlogRating { get; set; }

        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
