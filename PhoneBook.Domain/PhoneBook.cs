using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain
{
    internal class PhoneBook
    {
        public int Id { get; set; }
        public string ?PhoneNumber { get; set; }
        public string ?Name { get; set; }

        public virtual ApplicationUser ?User { get; set; }
        [ForeignKey("User")]
        public string ?UserId { get; set; }

    }
}
