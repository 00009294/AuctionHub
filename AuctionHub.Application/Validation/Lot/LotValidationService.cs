using AuctionHub.Application.UseCases.Lot.Models;
using AutoMapper;

namespace AuctionHub.Application.Validation.Lot
{
    public class LotValidationService : ILotValidationService
    {
        private readonly LotModel lotModel;
        private readonly IMapper mapper;
        private const int _percentage = 5 / 100;

        public LotValidationService(LotModel lotModel, IMapper mapper)
        {
            this.lotModel = lotModel;
            this.mapper = mapper;
        }

        public Domain.Entities.Lot ValidateLot(LotModel lotModel)
        {
            if (lotModel.NextPrice == true)
            {
                NextPrice(lotModel.StartingPrice, lotModel.CurrentPrice);
                // plus add 5 minutes to timer
            }

            // here should be a timer service
            
            var resultLot = this.mapper.Map<Domain.Entities.Lot>(lotModel);
            // when timer finishes 
            resultLot.FinishedPrice = lotModel.CurrentPrice;
            return resultLot;
        }

        private static void NextPrice(double startingPrice, double currentPrice)
        {
            if (currentPrice == 0)
            {
                startingPrice += startingPrice * _percentage;
            }
            currentPrice += currentPrice * _percentage;
        }
    }
}
