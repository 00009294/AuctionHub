using AuctionHub.Domain.Entities;

namespace AuctionHub.Application.Abstraction.Interfaces
{
    public interface IBidRepository
    {
        void Create(Bid bid);
        List<Bid> GetAll();
    }
}
