using AutoMapper;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;
using PhoneBook.Domain;
namespace PhoneBook.Application.Profiles
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<phoneBook, GetPhoneBookByUserIdViewModel>().ReverseMap();
         
        }
       
    }
}
