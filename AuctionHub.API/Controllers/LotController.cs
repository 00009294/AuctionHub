using AuctionHub.Application.UseCases.Lot.Commands;
using AuctionHub.Application.UseCases.Lot.Models;
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
        public async Task<LotModel> Post([FromQuery] LotModel lot)
        {
            var res = await this.mediator.Send(new CreateLotCommand { LotModel = lot });

            return res;
        }
    }
}
