using Microsoft.Extensions.DependencyInjection;
using SocialProject.Application.Services;
using SocialProject.Domain.Contracts;
using SocialProject.Persistence.App;

namespace SocialProject.Application
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddScoped<IAddressService, AddressService>();
            services.AddPersistence();
            return services;
        }
    }
}
