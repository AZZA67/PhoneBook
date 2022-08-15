using PhoneBook.Application.Features.User.Commands.CreateUser;
using PhoneBook.Application.Features.User.Commands.UserLogin;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<ApplicationUser> Register(CreateAccountCommand _user);
        Task<string> Login(UserLoginCommand _user);

    }
}
