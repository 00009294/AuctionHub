using AuctionHub.Application.Abstraction.Interfaces;
using AuctionHub.Application.UseCases.Lot.Commands;
using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Application.Validation.Lot;
using MediatR;

namespace AuctionHub.Application.UseCases.Lot.CommandHandlers
{
    public class CreateLotCommandHandler : IRequestHandler<CreateLotCommand, LotModelDtoForCreation>
    {
        private readonly ILotRepository lotRepository;
        private readonly ILotValidationService lotValidationService;

        public CreateLotCommandHandler(ILotRepository lotRepository, ILotValidationService lotValidationService)
        {
            this.lotRepository = lotRepository;
            this.lotValidationService = lotValidationService;
        }
        public Task<LotModelDtoForCreation> Handle(CreateLotCommand request, CancellationToken cancellationToken = default)
        {
            var validatedLot = this.lotValidationService.ValidateLotForCreation(request.lotModel);
            this.lotRepository.Create(validatedLot);

            return Task.FromResult(request.lotModel);
        }
    }
}
