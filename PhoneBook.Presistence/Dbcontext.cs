using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Presistence
{
   public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> options)
          : base(options)
        {
        }

        public DbSet<phoneBook> ?phonebooks { get; set; }

    }
}
