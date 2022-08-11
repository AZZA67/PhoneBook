using MediatR;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.User.Commands.CreateUser
{
    public class CreateAccountQuery : IRequest<ApplicationUser>
    {

    }
}
