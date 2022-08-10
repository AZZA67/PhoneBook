using MediatR;

namespace PhoneBook.Application.Features.PhoneBook.Queries.GetPhoneBooksByUserId
{
    internal class GetPhoneBooksByUserIdQuery: IRequest<List<GetPhoneBookByUserIdViewModel>>
    {
        public Guid UserId{ get; set; }
    }
}
