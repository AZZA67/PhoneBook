using AutoMapper;
using MediatR;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook
{
    public class CreatPhoneBookCommandHandler: IRequestHandler<CreatePhoneBookCommand, phoneBook>
    {
        private readonly IPhoneBookRepository _phoneBookRepository;
        private readonly IMapper _mapper;

        public CreatPhoneBookCommandHandler(IPhoneBookRepository PhoneBookRepository, IMapper mapper)
        {
            _phoneBookRepository = PhoneBookRepository;
            _mapper = mapper;
        }
        public async Task<phoneBook> Handle(CreatePhoneBookCommand request, CancellationToken cancellationToken)
        {
            phoneBook _phoneBook = _mapper.Map<phoneBook>(request);
           
               _phoneBook =  await _phoneBookRepository.Add(_phoneBook);
            return _phoneBook;


        }

     
    }
}
