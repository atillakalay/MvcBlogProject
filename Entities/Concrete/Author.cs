using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [StringLength(50)]
        public string AuthorName { get; set; }
        [StringLength(100)]
        public string AuthorImage { get; set; }
        [StringLength(250)]
        public string AuthorAbout { get; set; }
        [StringLength(50)]
        public string AuthorJob { get; set; }
        [StringLength(50)]
        public string AboutShort { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        public ICollection<Blog> Blogs { get; set; }

    }
}
