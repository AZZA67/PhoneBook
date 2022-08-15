using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;
using PhoneBook.Domain;
using System.Xml.Linq;

namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class UpdatePhoneBook:EndpointBaseAsync.WithRequest<UpdatePhoneBookCommand>.
        WithActionResult<phoneBook>
    {
        private readonly IMediator _mediator;

        public UpdatePhoneBook(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut("/UpdatePhoneBook")]
        public  async override Task<ActionResult<phoneBook>> HandleAsync([FromBody]UpdatePhoneBookCommand request, 
            CancellationToken cancellationToken = default)
        {
            return Ok(await _mediator.Send(request));
        }
      

    }
}
