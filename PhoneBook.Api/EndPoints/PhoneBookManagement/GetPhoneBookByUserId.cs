using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;
using PhoneBook.Domain;

namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class GetPhoneBookByUserId : EndpointBaseAsync.WithRequest<GetPhoneBooksByUserIdQuery>.
        WithActionResult<List<GetPhoneBookByUserIdViewModel>>
    {
        private readonly IMediator _mediator;

        public GetPhoneBookByUserId(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("/GetPhonebooksByUserId")]
        public async override Task<ActionResult<List<GetPhoneBookByUserIdViewModel>>>
            HandleAsync([FromRoute]GetPhoneBooksByUserIdQuery request, 
            CancellationToken cancellationToken = default)
        {
            var GetPhoneBooksByUserIdQuery = new GetPhoneBooksByUserIdQuery() { UserId = request.UserId };
          return Ok(await _mediator.Send(GetPhoneBooksByUserIdQuery));
        }
    }
}
