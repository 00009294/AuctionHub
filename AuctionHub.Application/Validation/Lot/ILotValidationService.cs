using AuctionHub.Application.UseCases.Lot.Models;

namespace AuctionHub.Application.Validation.Lot
{
    public interface ILotValidationService
    {
        Domain.Entities.Lot ValidateLot(LotModelDto lotModel);
        Domain.Entities.Lot ValidateLotForCreation(LotModelDtoForCreation lotModelDtoForCreation);
    }
}
