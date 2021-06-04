using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SubscribeMail
    {
        [Key]
        public int MailId { get; set; }
        [StringLength(50)]
        public string Email { get; set; }

    }
}
