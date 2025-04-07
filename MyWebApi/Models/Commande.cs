namespace MyWebApi.Models;

public class Commande
{
    public Guid Id { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public Guid ClientId { get; set; }
    public required Client Client { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}