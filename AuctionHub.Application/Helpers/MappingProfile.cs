using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Domain.Entities;
using AutoMapper;

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
