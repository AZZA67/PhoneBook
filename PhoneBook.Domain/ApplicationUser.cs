
using Microsoft.AspNetCore.Identity;
namespace PhoneBook.Domain
{
    public class ApplicationUser : IdentityUser { 
        public virtual List<phoneBook> ?PhoneBooks { get; set; }
    }
}


