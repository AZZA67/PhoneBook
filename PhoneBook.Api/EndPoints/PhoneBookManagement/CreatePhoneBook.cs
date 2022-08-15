using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;
using PhoneBook.Application.Features.User.Commands.CreateUser;
using PhoneBook.Domain;


namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class CreatePhoneBook: EndpointBaseAsync.WithRequest<CreatePhoneBookCommand>.
        WithActionResult<phoneBook>
    {
           private readonly IMediator _mediator;

    public CreatePhoneBook(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("/AddNewPhoneBook")]
    public override async Task<ActionResult<phoneBook>> HandleAsync([FromBody] CreatePhoneBookCommand request, CancellationToken cancellationToken = default)
    {
        return Ok(await _mediator.Send(request));
    }
}
}
        

     



