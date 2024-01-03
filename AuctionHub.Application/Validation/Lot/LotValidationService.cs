using AuctionHub.Application.UseCases.Lot.Models;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHub.Application.Validation.Lot
{
    public class LotValidationService : ILotValidationService
    {
        private readonly LotModel lotModel;
        private readonly IMapper mapper;
        private readonly int _percentage = 5;

        public LotValidationService(LotModel lotModel, IMapper mapper)
        {
            this.lotModel = lotModel;
            this.mapper = mapper;
        }

        public Domain.Entities.Lot ValidateLot(LotModel lotModel)
        {
            var resultLot = this.mapper.Map<Domain.Entities.Lot>(lotModel);
            // HERE MUST BE LOT VALIDATION SERVICE
            return resultLot;
        } 
    }
}
