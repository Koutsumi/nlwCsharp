using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;
using WebApplication1.Reposotories;

namespace WebApplication1.UseCase.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{

    public Auction? Execute() {

        var repository = new RocketseatAuctionDbContext();

        var today = DateTime.Now;

        return repository
            .Auctions
            .Include(auction => auction.Item)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }

}
