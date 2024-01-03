using AuctionHub.Application.UseCases.Lot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHub.Application.Validation.Lot
{
    public interface ILotValidationService
    {
        Domain.Entities.Lot ValidateLot(LotModel lotModel);
    }
}
