using AuctionHub.Application.UseCases.Lot.Models;
using MediatR;

namespace AuctionHub.Application.UseCases.Lot.Queries
{
    public class GetLotListQuery : IRequest<List<LotModelDto>>
    {
    }
}
