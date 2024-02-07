
using Microsoft.AspNetCore.Mvc;
using WebApplication1.UseCase.Auctions.GetCurrent;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuction() {
        return Ok("Fernanda");
    }

    [HttpGet("teste")]
    public IActionResult GetAuction()
    {
        var useCase = new GetCurrentAuctionUseCase();

        var result = useCase.Execute();

        return Ok(result);
    }
}
