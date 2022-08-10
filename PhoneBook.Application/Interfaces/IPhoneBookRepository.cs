using PhoneBook.Domain;
namespace PhoneBook.Application.Interfaces
{
    public interface IPhoneBookRepository
    {
        Task<IReadOnlyList<phoneBook>>  GetPhoneBookByUserId(Guid id);
        Task<int> Add(phoneBook phonebook);
        Task<int> Update(phoneBook phonebook);
        Task<int> delete(phoneBook phonebook);
    }
}
