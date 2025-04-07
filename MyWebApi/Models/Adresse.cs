namespace MyWebApi.Models;

public class Adresse
{
    public Guid Id { get; set; }
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }
    public required string Country { get; set; }
    public ICollection<Client> Clients { get; set; } = new List<Client>();
}