using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBook.Domain
{
    public class phoneBook
    {
        public Guid Id { get; set; }
        public string ?PhoneNumber { get; set; }
        public string ?Name { get; set; }

        public virtual ApplicationUser ?User { get; set; }

        [ForeignKey("User")]
        public string ?UserId { get; set; }

    }
}
