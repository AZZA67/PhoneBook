using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Api.DTO;
using PhoneBook.Domain;

namespace PhoneBook.Api.EndPoints.UseeManagementEndPoints
{
    public class CreateUser : EndpointBaseAsync.
        WithRequest<CreateUserViewModel>
        .WithActionResult<ApplicationUser>
    {

      private readonly  IMapper _mapper;
        private readonly IMediator _mediateR;
        private readonly ILogger _logger;   

        public CreateUser(ILogger logger, IMediator MediateR, IMapper Mapper)
        {
            _logger = logger;
            _mediateR = MediateR;
            _mapper = Mapper;   
        }
        [HttpPost("/CreateUser/AddNewUser")]
        public override Task<ActionResult<ApplicationUser>> HandleAsync(CreateUserViewModel request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Creating User Account");
            //var input = _mapper.Map<request, ApplicationUser>();
            throw new NotImplementedException();
        }

    }
}
