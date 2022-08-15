using AutoMapper;
using MediatR;
using PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Application.Features.PhoneBook.Commands.RemovePhoneBook
{
    public class RemovePhoneBookHandler : IRequestHandler<RemovePhoneBookCommand, int>
    {

        private readonly IPhoneBookRepository _phonebookRepository;
        private readonly IMapper _mapper;
        public RemovePhoneBookHandler(IPhoneBookRepository PhoneBookRepository, IMapper mapper)
        {
            _phonebookRepository = PhoneBookRepository;
            _mapper = mapper;
        }


       public async Task<int> Handle(RemovePhoneBookCommand request, CancellationToken cancellationToken)
        {
                var RowAffected = await _phonebookRepository.delete(request.PhoneBookId);
            return RowAffected;
        }
    }
}
