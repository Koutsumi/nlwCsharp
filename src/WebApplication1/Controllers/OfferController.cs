
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Communication.Requests;
using WebApplication1.Filters;

namespace WebApplication1.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    
    public IActionResult CreateOffer([FromRoute]int itemId, [FromBody] RequestCreateOfferJson request )
    {
        return Created();
    }
}
