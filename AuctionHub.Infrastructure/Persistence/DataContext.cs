using AuctionHub.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuctionHub.Infrastructure.Persistence
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
        
        }
        public DbSet<User> Users {  get; set; }
    }
}
