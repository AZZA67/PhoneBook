
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneBook.Domain
{
    internal class ApplicationUser : IdentityUser { 
        public virtual List<PhoneBook> ?PhoneBooks { get; set; }
    }
}

