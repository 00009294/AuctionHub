
using AuctionHub.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace AuctionHub.Domain.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = String.Empty;
        public double Balance { get; set; }

        public UserRole Role { get; set; } = UserRole.Guest;
    }
}
