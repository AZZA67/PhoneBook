using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;
using PhoneBook.Domain;
using System.Xml.Linq;

namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class UpdatePhoneBook
    {
        private readonly IMediator _mediator;

        public UpdatePhoneBook(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut("{id}", Name = "/Phonebook/UpdatePhonebook")]
        public async Task<phoneBook> UpdatePhonebook([FromBody] Guid id)
        {
            var _PhoneBook = new UpdatePhoneBookCommand() { PhoneBookId = id };
            return await _mediator.Send(_PhoneBook);
        }

    }
}
