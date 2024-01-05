using AuctionHub.Application.UseCases.Lot.Models;

namespace AuctionHub.Application.Validation.Lot
{
    public interface ILotValidationService
    {
        Domain.Entities.Lot ValidateLot(LotModel lotModel);
    }
}
