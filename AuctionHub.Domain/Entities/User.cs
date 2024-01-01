using AuctionHub.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.ObjectModel;

namespace AuctionHub.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; } = String.Empty;
        public double Balance { get; set; }

        public UserRole Role { get; set; }
        public Collection<Bid> Bids { get; set; }
    }
}
