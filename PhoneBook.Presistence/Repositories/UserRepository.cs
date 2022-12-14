using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PhoneBook.Application.Features.PhoneBook.Commands.CreatePhoneBook;
using PhoneBook.Application.Features.User.Commands.CreateUser;
using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Application.Interfaces;
using PhoneBook.Application.Features.User.Commands.UserLogin;

namespace PhoneBook.Presistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        Dbcontext context;
        private readonly SignInManager<ApplicationUser> signinmanager;
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserRepository(IHttpContextAccessor httpContextAccessor,
            SignInManager<ApplicationUser> signinmanager,
            UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager, 
            IConfiguration configuration, Dbcontext context)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
            this.context = context;
            this.signinmanager = signinmanager;
        }

        public async Task<ApplicationUser> Register(CreateAccountCommand _user)
        {
            var userExists = await userManager.FindByNameAsync(_user.UserName);
            ApplicationUser user = new ApplicationUser()
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = _user.UserName,
                PasswordHash = _user.Password
            };

            var result = await userManager.CreateAsync(user, _user.Password);
            return user;
        }

       
        public async Task<string> Login(UserLoginCommand model)
        {
            
               
         
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecrtKey"]));
                var token = new JwtSecurityToken(
                         issuer: _configuration["JWT:ValidIssuer"],
                         audience: _configuration["JWT:ValidAudience"],
                         expires: DateTime.Now.AddHours(3),

                         signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                         );

                var Tokenn = new JwtSecurityTokenHandler().WriteToken(token);
                return Tokenn;
            }
            return "UnAuthorized";

        }



    }
}
