using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.User.Commands.CreateUser;
using PhoneBook.Domain;

namespace PhoneBook.Api.EndPoints.UseeManagementEndPoints
{
    public class CreateUser:EndpointBaseAsync.WithRequest<CreateAccountCommand>.
        WithActionResult<ApplicationUser>
    {

      private readonly  IMapper _mapper;
       private readonly IMediator _mediateR;
       

        public CreateUser( IMediator MediateR, IMapper Mapper)
        {
            
            _mediateR = MediateR;
            _mapper = Mapper;
        }
        //[HttpPost("/AddNewUser")]
        //public async Task<ApplicationUser> AddNewUser([FromBody] CreateAccountCommand request,
        //    CancellationToken cancellationToken = default)
        //{
        //    return await _mediateR.Send(request);
        //}
        [HttpPost("/AddNewUser")]
        public override async Task<ActionResult<ApplicationUser>> HandleAsync([FromBody] CreateAccountCommand request, CancellationToken cancellationToken = default)
        {
            return Ok(await _mediateR.Send(request));
        }
    }
}
