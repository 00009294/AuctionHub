using AuctionHub.Application.UseCases.Lot.Models;
using MediatR;

namespace AuctionHub.Application.UseCases.Lot.Commands
{
    public class CreateLotCommand : IRequest<LotModelDtoForCreation>
    {
        public LotModelDtoForCreation lotModel { get; set; }
    }
}
