using MediatR;

namespace AuctionHub.Application.UseCases.Lot.Queries
{
    public class GetLotListQuery : IRequest<List<Domain.Entities.Lot>>
    {
    }
}
