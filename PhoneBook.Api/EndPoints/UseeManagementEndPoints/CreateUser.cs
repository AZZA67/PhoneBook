using Ardalis.ApiEndpoints;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.User.Commands.CreateUser;
using PhoneBook.Domain;

namespace PhoneBook.Api.EndPoints.UseeManagementEndPoints
{
    public class CreateUser 
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
        [HttpPost("/AddNewUser")]
        public async Task<ApplicationUser> AddNewUser(CreateAccountCommand request,
            CancellationToken cancellationToken = default)
        {
            return await _mediateR.Send(request);
        }
    }
}
