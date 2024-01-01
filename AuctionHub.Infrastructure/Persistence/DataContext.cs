using AuctionHub.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuctionHub.Infrastructure.Persistence
{
    public class DataContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new { e.Id });
            });
            modelBuilder.Entity<Bid>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bids)
                .HasForeignKey(b => b.UserId);

            modelBuilder.Entity<Bid>()
                .HasOne(b => b.Lot)
                .WithMany(l => l.Bids)
                .HasForeignKey(b => b.LotId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Lot>()
                .HasOne(l => l.User)
                .WithMany()
                .HasForeignKey(l => l.UserId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public new DbSet<User> Users { get; set; }
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Bid> Bids { get; set; }
        //public DbSet<Location> Locations { get; init; }
    }
}
