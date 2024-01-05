using AuctionHub.Application.Helpers;
using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Application.Validation.Lot;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AuctionHub.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ILotValidationService, LotValidationService>();
            services.AddScoped<LotModel>();
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
