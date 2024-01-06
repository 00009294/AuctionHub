using AuctionHub.Application.Helpers;
using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Application.UseCases.Lot.Queries;
using AuctionHub.Application.UseCases.Lot.QueryHandlers;
using AuctionHub.Application.Validation.Lot;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AuctionHub.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ILotValidationService, LotValidationService>();
            services.AddScoped<LotModelDtoForCreation>();
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddTransient<IRequestHandler<GetLotListQuery, List<LotModelDto>>, GetLotListQueryHandler>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
