using AuctionHub.Application.Abstraction.Interfaces;
using AuctionHub.Application.UseCases.Lot.Commands;
using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHub.Application.UseCases.Lot.CommandHandlers
{
    public class UpdateLotCommandHandler : IRequestHandler<UpdateLotCommand, LotModelDtoForUpdate>
    {
        private readonly ILotRepository lotRepository;
        private readonly IMapper mapper;

        public UpdateLotCommandHandler(ILotRepository lotRepository,IMapper mapper)
        {
            this.lotRepository = lotRepository;
            this.mapper = mapper;
        }
        public Task<LotModelDtoForUpdate> Handle(UpdateLotCommand request, CancellationToken cancellationToken)
        {
            var res = this.mapper.Map<Domain.Entities.Lot>(request);
            this.lotRepository.Update(res.Id, res);
            var lotModelDtoForUpdate = this.mapper.Map<LotModelDtoForUpdate>(res);
            
            return Task.FromResult(lotModelDtoForUpdate);
        }

       
    }
}
