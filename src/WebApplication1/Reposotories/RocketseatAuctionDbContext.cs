using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Reposotories;

public class RocketseatAuctionDbContext : DbContext 
{
    public DbSet<Auction> Auctions { get; set; }
    // dar o nome da tabela que consta no banco (Auctions)
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\projects\estudos\rocketseatAction\leilaoDbNLW.db");
    }
}
