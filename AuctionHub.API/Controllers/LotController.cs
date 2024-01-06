using AuctionHub.Application.UseCases.Lot.Commands;
using AuctionHub.Application.UseCases.Lot.Models;
using AuctionHub.Application.UseCases.Lot.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuctionHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotController : ControllerBase
    {
        private readonly IMediator mediator;

        public LotController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<LotModelDtoForCreation> Post([FromQuery] LotModelDtoForCreation lot)
        {
            var res = await this.mediator.Send(new CreateLotCommand { lotModel = lot });

            return res;
        }

        [HttpGet]
        public async Task<List<LotModelDto>> Get()
        {
            return await this.mediator.Send(new GetLotListQuery());
        }

        [HttpPut]
        public async Task<LotModelDtoForUpdate> Put([FromBody] LotModelDtoForUpdate lot)
        {
            return await this.mediator.Send(new UpdateLotCommand { lotModelDtoForUpdate = lot });
        }
    }
}
