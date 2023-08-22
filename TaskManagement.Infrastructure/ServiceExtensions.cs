using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Application.Interfaces;
using TaskManagement.Infrastructure.Services.UserManagement;

namespace TaskManagement.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigureInfrastructure(this IServiceCollection services )
        {
            services.AddScoped<IUserRegistarionService, UserRegistarionService>();
            services.AddScoped<ILoginService, LoginService>();

        }
    }
}
