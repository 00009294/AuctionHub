using AuctionHub.Application.Abstraction.Interfaces;
using AuctionHub.Domain.Entities;
using AuctionHub.Domain.Enums;
using AuctionHub.Infrastructure.Persistence;

namespace AuctionHub.Infrastructure.Repositories
{
    public class LotRepository : ILotRepository
    {
        private readonly DataContext dataContext;

        public LotRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void Create(Lot entity)
        {
            try
            {
                if(entity == null)
                {
                    throw new ArgumentNullException();
                }
                this.dataContext.Lots.Add(entity);
            }
            catch (Exception)
            {
                throw new Exception("Ooops, lot has not uploaded");
            }
            finally
            {
                this.dataContext.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            try
            {
                var lot = this.dataContext.Lots.FirstOrDefault(l => l.Id == id);
                if (lot == null)
                {
                    throw new ArgumentNullException(nameof(lot));
                }
                this.dataContext.Lots.Remove(lot);
            }
            catch (Exception)
            {
                throw new Exception("Ooops, lot has not removed");
            }
            finally
            {
                this.dataContext.SaveChanges();
            }
        }

        public List<Lot> GetAll()
        {
            return this.dataContext.Lots.ToList();
        }
        public void Update(Guid id, Lot entity)
        {
           throw new NotImplementedException();
        }

        public Lot GetByCategory(string category)
        {
            try
            {
                var lot = this.dataContext.Lots.FirstOrDefault(l => l.Category.ToString() == category);
                if (lot == null)
                {
                    throw new ArgumentNullException();
                }
                return lot;
            }
            catch (Exception)
            {
                throw new Exception("Ooops, smth happened while searching by category");
            }
        }

        public Lot GetById(Guid id)
        {
            try
            {
                var lot = this.dataContext.Lots.FirstOrDefault(l => l.Id == id);
                if (lot == null)
                {
                    throw new ArgumentNullException();
                }
                return lot;
            }
            catch (Exception)
            {
                throw new Exception("Ooops, smth happened while searching");
            }
        }

        public Lot GetByLocation(string location)
        {
            try
            {
                var lot = this.dataContext.Lots.FirstOrDefault(l => l.Location.ToString() == location);
                if (lot == null)
                {
                    throw new ArgumentNullException();
                }
                return lot;
            }
            catch (Exception)
            {
                throw new Exception("Ooops, smth happened while searching locations");
            }
        }

        public Lot GetByName(string name)
        {
            try
            {
                var lot = this.dataContext.Lots.FirstOrDefault(l => l.ItemName == name);
                if (lot == null)
                {
                    throw new ArgumentNullException();
                }
                return lot;
            }
            catch (Exception)
            {
                throw new Exception("Ooops, smth happened while searching item name");
            }
        }

        public List<Lot> GetByPrice(double fromPrice, double toPrice)
        {
            try
            {
                var lots = this.dataContext.Lots.ToList();
                List<Lot> selectedLots = new List<Lot>();
                foreach (var lot in lots)
                {
                    if (lot.StartingPrice >= fromPrice || lot.CurrentPrice <= toPrice)
                    {
                        selectedLots.Add(lot);
                    }
                }
                return selectedLots;
            }
            catch (Exception)
            {
                throw new Exception("Ooops, couldn't find range of prices");
            };
        }

        public Lot GetByStatus(string status)
        {
            try
            {
                var lot = this.dataContext.Lots.FirstOrDefault(l => l.LotStatus.ToString() == status);
                if (lot == null)
                {
                    throw new ArgumentNullException();
                }
                return lot;
            }
            catch (Exception)
            {
                throw new Exception("Ooops, smth happened while searching by item status");
            }
        }

    }
}
