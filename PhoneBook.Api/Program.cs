using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using PhoneBook.Application;
using PhoneBook.Application.Interfaces;
using PhoneBook.Presistence;
using PhoneBook.Presistence.Repositories;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager Configuration = builder.Configuration; //also you can use builderkeyword
IWebHostEnvironment environment = builder.Environment;
// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var app = builder.Build();

//builder.Services.AddControllers();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseAuthorization();

//app.MapControllers();

app.Run();
