using AutoMapper;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Commands.RemovePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;
using PhoneBook.Domain;
namespace PhoneBook.Application.Profiles
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<phoneBook, GetPhoneBookByUserIdViewModel>().ReverseMap();
            CreateMap<phoneBook, CreatePhoneBookCommand>().ReverseMap();
            CreateMap<phoneBook, UpdatePhoneBookCommand>().ReverseMap();
            CreateMap<phoneBook, RemovePhoneBookCommand>().ReverseMap();


        }
       
    }
}
