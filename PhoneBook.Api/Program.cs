using Microsoft.AspNetCore.Mvc;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Commands.RemovePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook;
using PhoneBook.Application.Features.User.Commands.CreateUser;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager Configuration = builder.Configuration; 
IWebHostEnvironment environment = builder.Environment;
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseAuthorization();
app.MapPost("/Phonebook/CreatePhoneBook", ([FromBody] CreatePhoneBookCommand cmd) => { } );
app.MapPost("/AddNewUser", ([FromBody] CreateAccountCommand cmd) => { });
app.MapPut("/Phonebook/UpdatePhonebook", ([FromBody] UpdatePhoneBookCommand umd) => { }  );
app.MapDelete("/Phonebook/UpdatePhoneBook", ([FromBody] RemovePhoneBookCommand umd) => { });
app.MapGet("/Phonebook/GetPhonebooksByUserId/{id}", (Guid id) => { });
app.Run();