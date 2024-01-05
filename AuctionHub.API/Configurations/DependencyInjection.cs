using AuctionHub.Application;
using AuctionHub.Infrastructure;
using System.Reflection;

namespace AuctionHub.API.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAllConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddInfrastructure(configuration);
            services.AddApplication();

            return services;
        }
    }
}
