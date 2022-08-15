using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.User.Commands.UserLogin;

namespace PhoneBook.Api.EndPoints.UseeManagementEndPoints
{
    public class UserLogin : EndpointBaseAsync.WithRequest<UserLoginCommand>.
        WithActionResult<string>
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediateR;


        public UserLogin(IMediator MediateR, IMapper Mapper)
        {

            _mediateR = MediateR;
            _mapper = Mapper;
        }
        [HttpPost("/LoginUser")]
        public async  override Task<ActionResult<string>> 
            HandleAsync(UserLoginCommand request, CancellationToken cancellationToken = default)
        {

            string flag = await _mediateR.Send(request);
            if (flag != "UnAuthorized")
                return Ok(flag);
            else
                return BadRequest(flag);

        }
    }
}
