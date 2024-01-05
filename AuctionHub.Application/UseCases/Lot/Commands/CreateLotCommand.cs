using AuctionHub.Application.UseCases.Lot.Models;
using MediatR;

namespace AuctionHub.Application.UseCases.Lot.Commands
{
    public class CreateLotCommand : IRequest<LotModel>
    {
        public LotModel LotModel { get; set; }
    }
}
