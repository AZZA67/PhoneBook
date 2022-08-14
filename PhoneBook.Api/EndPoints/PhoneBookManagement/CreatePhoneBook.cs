using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;
using PhoneBook.Domain;

namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class CreatePhoneBook
    {

        private readonly IMediator _mediator;

        public CreatePhoneBook(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("/Phonebook/CreatePhoneBook")]
        public async Task<phoneBook> HandleAsync(CreatePhoneBookCommand request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(request);

        }

    }
}
