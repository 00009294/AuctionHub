using AuctionHub.Application.UseCases.Lot.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHub.Application.UseCases.Lot.Commands
{
    public class CreateLotCommand : IRequest<LotModel>
    {
        public LotModel LotModel { get; set; }
    }
}
