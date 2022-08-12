using Microsoft.Extensions.DependencyInjection;
using SocialProject.Domain.Contracts.Adapters;
using SocialProject.Persistence.App.Adapters;
using SocialProject.Persistence.App.Repositories;
using SocialProject.Persistence.App.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Persistence.App
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressAdapter, AddressAdapter>();
            services.AddDbContext<ProjectoSolidarioDBContext>();
            return services;
        }
    }
}
