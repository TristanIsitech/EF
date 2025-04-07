namespace MyWebApi.Models;

public class Client
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public Guid AdresseId { get; set; }
    public required Adresse Adresse { get; set; }
    public ICollection<Commande> Commandes { get; set; } = new List<Commande>();
}