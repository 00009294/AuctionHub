using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHub.Application.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lot, LotModel>().ReverseMap();
        }
    }
}
