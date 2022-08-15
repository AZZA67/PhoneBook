using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.PhoneBook.Commands.RemovePhoneBook
{
    public class RemovePhoneBookCommand : IRequest<int>
    {
        
            public Guid PhoneBookId { get; set; }
    }
}
