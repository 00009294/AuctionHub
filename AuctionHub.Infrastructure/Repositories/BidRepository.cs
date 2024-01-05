using AuctionHub.Application.Abstraction.Interfaces;
using AuctionHub.Domain.Entities;
using AuctionHub.Infrastructure.Persistence;

namespace AuctionHub.Infrastructure.Repositories
{
    public class BidRepository : IBidRepository
    {
        private readonly DataContext dataContext;

        public BidRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void Create(Bid bid)
        {
            try
            {
                if (bid != null)
                {
                    this.dataContext.Bids.Add(bid);
                }
            }
            catch (Exception)
            {
                throw new Exception("Ooops, couldn't bid for lot");
            }
            finally
            {
                this.dataContext.SaveChanges();
            }
        }

        public List<Bid> GetAll()
        {
            return this.dataContext.Bids.ToList();
        }
    }
}
