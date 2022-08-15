using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;

namespace PhoneBook.Api.EndPoints.PhoneBookManagement
{
    public class GetPhoneBookByUserId
    {
        private readonly IMediator _mediator;

        public GetPhoneBookByUserId(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{id}", Name = "/Phonebook/GetPhonebooksByUserId")]
        public async Task<List<GetPhoneBookByUserIdViewModel>> GetPhoneBookByUserid(Guid id)
        {
            var GetPhoneBooksByUserIdQuery = new GetPhoneBooksByUserIdQuery() { UserId = id };
            return await _mediator.Send(GetPhoneBooksByUserIdQuery);
        }

    }
}
