using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Application.Interfaces;
using PhoneBook.Presistence.Repositories;
using Microsoft.Extensions.Configuration;

namespace PhoneBook.Presistence
{
    public static class PresistenceContainer
    {
        //public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        //{
        //    //services.AddDbContext<Dbcontext>(options =>
        //    //    options.UseSqlServer(configuration.GetConnectionString("Cs")));

        //    //services.AddScoped<IPhoneBookRepository,PhoneBookRepository>();
         
        //    //return services;
        //}
    }
}
