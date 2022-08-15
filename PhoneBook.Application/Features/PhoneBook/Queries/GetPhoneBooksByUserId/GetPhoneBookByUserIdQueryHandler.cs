using AutoMapper;
using MediatR;
using PhoneBook.Application.Interfaces;

namespace PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId
{
    public class GetPhoneBookByUserIdQueryHandler : IRequestHandler<GetPhoneBooksByUserIdQuery, List<GetPhoneBookByUserIdViewModel>>
    {
        private readonly IPhoneBookRepository _phonebookRepository;
        private readonly IMapper _mapper;
        public GetPhoneBookByUserIdQueryHandler(IPhoneBookRepository PhoneBookRepository, IMapper mapper)
        {
            _phonebookRepository = PhoneBookRepository;
            _mapper = mapper;
        }
        public async Task<List<GetPhoneBookByUserIdViewModel>> Handle(GetPhoneBooksByUserIdQuery request, CancellationToken cancellationToken)
        {
            var allPhonebooks =   await _phonebookRepository.GetPhoneBookByUserId(request.UserId);
            return _mapper.Map<List<GetPhoneBookByUserIdViewModel>>(allPhonebooks);
        }
    }
}
