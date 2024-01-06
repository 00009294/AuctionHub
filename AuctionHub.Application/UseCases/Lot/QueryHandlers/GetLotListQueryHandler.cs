using AuctionHub.Application.Abstraction.Interfaces;
using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Application.UseCases.Lot.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHub.Application.UseCases.Lot.QueryHandlers
{
    public class GetLotListQueryHandler : IRequestHandler<GetLotListQuery, List<LotModelDto>>
    {
        private readonly ILotRepository lotRepository;
        private readonly IMapper mapper;

        public GetLotListQueryHandler(ILotRepository lotRepository, IMapper  mapper)
        {
            this.lotRepository = lotRepository;
            this.mapper = mapper;
        }
        public Task<List<LotModelDto>> Handle(GetLotListQuery request, CancellationToken cancellationToken)
        {
            var res = this.lotRepository.GetAll();
            return Task.FromResult(this.mapper.Map<List<LotModelDto>>(res));
        }
    }
}
