namespace PhoneBook.Api.DTO
{
    public class CreateUserViewModel
    {
        public string ?UserName { get; set; }
        public string ?Password { get; set; }
        public string ?ConfirmPassword { get; set; }
    }
}
