using MediatR;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook
{
    public class CreatePhoneBookCommand: IRequest<phoneBook>
    {
        public Guid Id { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Name { get; set; }
        public string? UserId { get; set; }
    }
}
