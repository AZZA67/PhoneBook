using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Commands.RemovePhoneBook;
using PhoneBook.Application.Features.PhoneBook.Commands.UpdatePhoneBook;
using PhoneBook.Application.Features.User.Commands.CreateUser;
using PhoneBook.Application.Interfaces;
using PhoneBook.Domain;
using PhoneBook.Presistence;
using PhoneBook.Presistence.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager Configuration = builder.Configuration; 
IWebHostEnvironment environment = builder.Environment;
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IPhoneBookRepository, PhoneBookRepository>();

//builder.Services.AddSwaggerGen(c => {
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
//    c.EnableAnnotations();
//});
builder.Services.AddOptions();
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
var assembly = Assembly.GetExecutingAssembly();
builder.Services.AddMediatR(assembly);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddLogging();
builder.Services.AddHttpContextAccessor();
builder.Services.Configure<ClaimsIdentityOptions>(x => x.UserIdClaimType = ClaimTypes.NameIdentifier);
builder.Services.AddHttpClient();
builder.Services.AddDbContext<Dbcontext>();
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<Dbcontext>()
                .AddDefaultTokenProviders();

builder.Services.AddIdentityCore<ApplicationUser>();


JwtSecurityTokenHandler.DefaultInboundClaimTypeMap = new Dictionary<string, string>();


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters =
           new TokenValidationParameters()
           {
               ValidateIssuer = true,
               ValidIssuer = Configuration["JWT:ValidIssuer"],
               ValidateAudience = true,
               ValidAudience = Configuration["JWT:ValidAudience"],
               IssuerSigningKey =
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:SecrtKey"]))
           };
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();