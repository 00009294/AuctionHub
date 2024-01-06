using AuctionHub.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AuctionHub.Application.UseCases.Lot.Models
{
    public class LotModel
    {

        [Required(ErrorMessage = "Item name is required")]
        [StringLength(15)]
        public string ItemName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = String.Empty;

        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue, ErrorMessage = "Starting price must be a non-negative value")]
        public double StartingPrice { get; set; }
        public double CurrentPrice { get; set; }
        public bool NextPrice { get; set; }
        public string ImageURL { get; set; } = String.Empty;

        [Required]
        public DateTime ExpirationTime { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Currency Currency { get; set; }

        [Required]
        public LotStatus LotStatus { get; set; } = LotStatus.Active;

        [Required]
        public Location Location { get; set; }


    }
}
