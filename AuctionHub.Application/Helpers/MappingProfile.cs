using AuctionHub.Application.UseCases.Lot.Commands;
using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Domain.Entities;
using AutoMapper;

namespace AuctionHub.Application.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lot, LotModelDto>().ReverseMap();
            CreateMap<Lot, LotModelDtoForUpdate>().ReverseMap();
            CreateMap<Lot, LotModelDtoForCreation>().ReverseMap();
            CreateMap<LotModelDtoForCreation, LotModelDtoForUpdate>().ReverseMap();
            CreateMap<Lot, UpdateLotCommand>().ReverseMap();

        }
    }
}
