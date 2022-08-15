using AutoMapper;
using MediatR;
using PhoneBook.Application.Features.User.Commands.CreateUser;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.User.Commands.UserLogin
{
    public class UserLoginHandler : IRequestHandler<UserLoginCommand, string>
    {
       
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserLoginHandler(IUserRepository userRepository, IMapper mapper)
        {

            _userRepository = userRepository;
            _mapper = mapper;
        }
        public  async Task<string> Handle(UserLoginCommand request, CancellationToken cancellationToken)
        {

           string flag = await _userRepository.Login(request);
            return flag;

        }
    }
}
