using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;

namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class GetPhoneBookByUserId: EndpointBaseAsync.
        WithRequest<GetPhoneBooksByUserIdQuery>
        .WithActionResult<List<GetPhoneBookByUserIdViewModel>>
    {
        private readonly IMediator _mediator;

        public GetPhoneBookByUserId(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet("/Phonebook/GetPhonebbok")]
        internal async Task<ActionResult<List<GetPhoneBookByUserIdViewModel>>> GetAllPhoneBooks()
        {
            var dtos = await _mediator.Send(new GetPhoneBooksByUserIdQuery());
            return Ok(dtos);
        }
        [HttpGet("/Phonebook/GetPhonebbok")]
        public override Task<ActionResult<List<GetPhoneBookByUserIdViewModel>>> HandleAsync(GetPhoneBooksByUserIdQuery request, CancellationToken cancellationToken = default)
        {

             
            throw new NotImplementedException();
        }
    }
}
