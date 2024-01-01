using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionHub.Domain.Entities
{
    public class Bid
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public DateTime Time { get; set; }

        [ForeignKey("LotId")]
        public Lot Lot { get; set; }
        public Guid LotId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
