using MediatR;
using AuctionHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHub.Application.UseCases.Lot.Queries
{
    public class GetLotListQuery : IRequest<List<Domain.Entities.Lot>>
    {
    }
}
