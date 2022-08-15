using AutoMapper;
using MediatR;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.User.Commands.CreateUser
{
    public class CreateAccountHandler : IRequestHandler<CreateAccountCommand, ApplicationUser>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateAccountHandler(IUserRepository userRepository, IMapper mapper)
        {
           
            _userRepository = userRepository;
            _mapper = mapper;   
        }

        public async Task<ApplicationUser> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
          ApplicationUser user = await _userRepository.Register(request);
          return user;
        }
    }
}
