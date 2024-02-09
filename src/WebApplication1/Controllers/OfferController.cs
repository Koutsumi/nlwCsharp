
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute]int itemId)
    {
        return Created();
    }
}
