using Microsoft.EntityFrameworkCore;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Presistence.Repositories
{
    public class PhoneBookRepository: IPhoneBookRepository
    {
        Dbcontext dbcontext;
        public PhoneBookRepository(Dbcontext dbcontext)
        {
        this.dbcontext = dbcontext; 
        }
        public async Task<IReadOnlyList<phoneBook>> GetPhoneBookByUserId(Guid id)
        {
            List<phoneBook> allphonebooks = new List<phoneBook>();
            if (dbcontext.phonebooks !=null)
            allphonebooks = await  dbcontext.phonebooks.Include(phonebook => phonebook.User).ToListAsync();
            return allphonebooks;
        }

        public async Task<int> Add(phoneBook phonebook)
        {
            if (dbcontext.phonebooks != null)

               dbcontext.phonebooks.Add(phonebook);
             return await dbcontext.SaveChangesAsync();

          
        }
        public async Task<int> Update(phoneBook phonebook)
        {
            if (dbcontext.phonebooks != null)
                dbcontext.Entry(phonebook).State = EntityState.Modified;
            return  await dbcontext.SaveChangesAsync();


        }

        public async Task<int> delete(phoneBook phonebook)
        {
            if (dbcontext.phonebooks != null)
                dbcontext.phonebooks.Remove(phonebook);
            return  await dbcontext.SaveChangesAsync();


        }

      



    }
}
