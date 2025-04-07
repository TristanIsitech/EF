using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Adresse> Adresses { get; set; }
    public DbSet<Commande> Commandes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new AdresseConfiguration());
        modelBuilder.ApplyConfiguration(new CommandeConfiguration());
    }
}
