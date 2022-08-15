using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.RemovePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook;
using PhoneBook.Domain;
using System.Xml.Linq;

namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class RemovePhoneBook
    {
        private readonly IMediator _mediator;

        public RemovePhoneBook(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpDelete("{id}", Name = "/Phonebook/RemovePhonebook")]
        public async Task<int> delete([FromBody] Guid id)
        {
            var _PhoneBook = new RemovePhoneBookCommand() { PhoneBookId = id };
            return await _mediator.Send(_PhoneBook);
        }
    }
}
