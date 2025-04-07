namespace MyWebApi.Models;

public class Product
{
    public Guid Id { get; set; }
    public required string Name { get; set; } 
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsAvailable { get; set; } = false;

}
