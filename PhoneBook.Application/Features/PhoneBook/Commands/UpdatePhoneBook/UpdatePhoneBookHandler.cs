using AutoMapper;
using MediatR;
using PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook
{
    public class UpdatePhoneBookHandler : IRequestHandler<UpdatePhoneBookCommand, phoneBook>
    {
        private readonly IPhoneBookRepository _phonebookRepository;
        private readonly IMapper _mapper;
        public UpdatePhoneBookHandler(IPhoneBookRepository PhoneBookRepository, IMapper mapper)
        {
            _phonebookRepository = PhoneBookRepository;
            _mapper = mapper;
        }

       public async Task<phoneBook> Handle(UpdatePhoneBookCommand request, CancellationToken cancellationToken)
        {
                var phonebook = await _phonebookRepository.Update(request.PhoneBookId);
               return _mapper.Map<phoneBook>(phonebook);
        }
    }
}
