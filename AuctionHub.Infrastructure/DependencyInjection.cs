using AuctionHub.Application.Abstraction.Interfaces;
using AuctionHub.Domain.Entities;
using AuctionHub.Infrastructure.Persistence;
using AuctionHub.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuctionHub.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ILotRepository, LotRepository>();
            services.AddScoped<IBidRepository, BidRepository>();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") ??
                    throw new InvalidOperationException("Connection String is not found"));
            });


            services.AddIdentityApiEndpoints<User>()
                .AddEntityFrameworkStores<DataContext>()
                .AddSignInManager();



            return services;
        }

    }
}
