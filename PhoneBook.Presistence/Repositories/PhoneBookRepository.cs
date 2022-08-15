using Microsoft.EntityFrameworkCore;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain;

namespace PhoneBook.Presistence.Repositories
{
    public class PhoneBookRepository :IPhoneBookRepository
    {
        Dbcontext dbcontext;
        public PhoneBookRepository(Dbcontext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public async Task<IReadOnlyList<phoneBook>> GetPhoneBookByUserId(Guid id)
        {
            List<phoneBook> allphonebooks = new List<phoneBook>();
            if (dbcontext.phonebooks != null)
                allphonebooks = await dbcontext.phonebooks.Include(phonebook => phonebook.User).ToListAsync();
            return allphonebooks;
        }

        public async Task<phoneBook> Add(phoneBook phonebook)
        {
            if (dbcontext.phonebooks != null)

                dbcontext.phonebooks.Add(phonebook);

            await dbcontext.SaveChangesAsync();
            return phonebook;



        }
        public async Task<int> Update(Guid phonebookId)
        {
            phoneBook? _phonebook = dbcontext.phonebooks.FirstOrDefault(ph => ph.Id == phonebookId);
            if (_phonebook != null)
                dbcontext.phonebooks.Update(_phonebook);
            return await dbcontext.SaveChangesAsync();


        }


        public async Task<int> delete(Guid phonebookId)
        {
            phoneBook? _phonebook = dbcontext.phonebooks.FirstOrDefault(ph => ph.Id == phonebookId);
            if (_phonebook != null)
                dbcontext.phonebooks.Remove(_phonebook);
            return await dbcontext.SaveChangesAsync();


        }


      





    }
}
