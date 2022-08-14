using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PhoneBook.Presistence
{
   public class Dbcontext : IdentityDbContext<ApplicationUser>
    {
        
        public Dbcontext()
        { }

        public Dbcontext(DbContextOptions<Dbcontext> options)
           : base(options)
        {
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer("Data Source=DESKTOP-CKHD3I1\\SQLEXPRESS; Initial Catalog = PhoneBook; Integrated Security = True; TrustServerCertificate=True");

        public DbSet<phoneBook> ?phonebooks { get; set; }


    }
}
