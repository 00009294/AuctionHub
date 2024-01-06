using AuctionHub.Application.UseCases.Lot.Models;
using AutoMapper;

namespace AuctionHub.Application.Validation.Lot
{
    public class LotValidationService : ILotValidationService
    {
        private readonly LotModelDtoForCreation lotModel;
        private readonly IMapper mapper;
        private const int _percentage = 5 / 100;

        public LotValidationService(LotModelDtoForCreation lotModel, IMapper mapper)
        {
            this.lotModel = lotModel;
            this.mapper = mapper;
        }

        public Domain.Entities.Lot ValidateLot(LotModelDto lotModel)
        {
            if (lotModel.NextPrice == true)
            {
                NextPrice(lotModel.StartingPrice);
                // plus add 5 minutes to timer
            }

            // here should be a timer service
            
            var resultLot = this.mapper.Map<Domain.Entities.Lot>(lotModel);
            // when timer finishes 
            return resultLot;
        }

        private static void NextPrice(double startingPrice)
        {
            startingPrice += startingPrice * _percentage;
        }

        public Domain.Entities.Lot ValidateLotForCreation(LotModelDtoForCreation lotModelDtoForCreation)
        {
            return this.mapper.Map<Domain.Entities.Lot>(lotModelDtoForCreation);
        }
    }
}
