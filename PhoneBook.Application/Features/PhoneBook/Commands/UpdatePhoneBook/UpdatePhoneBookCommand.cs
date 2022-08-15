using MediatR;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook
{
    public class UpdatePhoneBookCommand : IRequest<phoneBook>
    {
        public Guid PhoneBookId { get; set; }
    }
}
