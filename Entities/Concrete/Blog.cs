using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }

        [StringLength(100)]
        public string BlogTitle { get; set; }

        [StringLength(100)]
        public string BlogImage { get; set; }

        public DateTime BlogDate { get; set; }
        public string BlogContent { get; set; }
        public int BlogRating { get; set; }

        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
