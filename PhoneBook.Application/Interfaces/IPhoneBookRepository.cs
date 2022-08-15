using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Interfaces
{
    public interface IPhoneBookRepository
    {

       
            Task<phoneBook> Add(phoneBook phonebook);
            Task<int> delete(Guid phonebookId);
            Task<IReadOnlyList<phoneBook>> GetPhoneBookByUserId(Guid id);
            Task<phoneBook> Update(phoneBook phoneBook);
        
    }
}

