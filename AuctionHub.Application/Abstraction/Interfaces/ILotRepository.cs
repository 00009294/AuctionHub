using AuctionHub.Domain.Entities;

namespace AuctionHub.Application.Abstraction.Interfaces
{
    public interface ILotRepository : IBaseRepository<Lot>
    {
        Lot GetByName(string name);
        List<Lot> GetByPrice(double fromPrice, double toPrice);
        Lot GetByCategory(string category);
        Lot GetByStatus(string status);
        Lot GetByLocation(string location);
    }
}
