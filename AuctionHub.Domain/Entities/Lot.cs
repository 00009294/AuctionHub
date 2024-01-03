using AuctionHub.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionHub.Domain.Entities
{
    public class Lot
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public double StartingPrice { get; set; }
        public double CurrentPrice { get; set; }
        public double Deposit { get; set; }
        public string ImageURL { get; set; } = String.Empty;
        public DateTime ExpirationTime { get; set; }

        public Category Category { get; set; }
        public Currency Currency { get; set; }
        public LotStatus LotStatus { get; set; }
        public Location Location { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } = new User();
        public Guid UserId { get; set; }
        public Guid WinnerId { get; set; }

        public ICollection<Bid> Bids { get; set; } = new List<Bid>();
    }
}
