using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.RemovePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook;
using PhoneBook.Domain;
using System.Xml.Linq;

namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class RemovePhoneBook:EndpointBaseAsync.WithRequest<RemovePhoneBookCommand>.
        WithActionResult<int>
    {
        private readonly IMediator _mediator;

        public RemovePhoneBook(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpDelete("/RemovePhonebook")]
        public async override Task<ActionResult<int>> 
            HandleAsync([FromRoute] RemovePhoneBookCommand request, 
            CancellationToken cancellationToken = default)
        {
            var _PhoneBook = new RemovePhoneBookCommand() { PhoneBookId = request.PhoneBookId };
            return Ok(await _mediator.Send(_PhoneBook));
        }
    }
}
