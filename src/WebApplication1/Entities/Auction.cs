namespace WebApplication1.Entities;

public class Auction
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }
    public List<Item> Item { get; set; } = [];// new List<Item>(); // caso n seja preenchido deve retornar uma lista vazia
}
