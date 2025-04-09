using MyWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MyWebApi.SeedData;

public static class LocationSeedData
{
    public static readonly Location Location1 = new Location
    {
        Id = Guid.NewGuid(),
        Name = "Centre des Congrès",
        Address = "123 Rue des Événements",
        City = "Paris",
        Country = "France",
        Capacity = 500
    };

    public static readonly Location Location2 = new Location
    {
        Id = Guid.NewGuid(),
        Name = "Stade National",
        Address = "456 Avenue des Sports",
        City = "Lyon",
        Country = "France",
        Capacity = 20000
    };

    public static readonly Location Location3 = new Location
    {
        Id = Guid.NewGuid(),
        Name = "Salle Polyvalente",
        Address = "789 Rue des Loisirs",
        City = "Marseille",
        Country = "France",
        Capacity = 300
    };

    public static readonly Location Location4 = new Location
    {
        Id = Guid.NewGuid(),
        Name = "Théâtre Royal",
        Address = "101 Rue des Arts",
        City = "Bordeaux",
        Country = "France",
        Capacity = 800
    };

    public static readonly Location Location5 = new Location
    {
        Id = Guid.NewGuid(),
        Name = "Parc des Expositions",
        Address = "202 Avenue des Foires",
        City = "Toulouse",
        Country = "France",
        Capacity = 10000
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Location>().HasData(Location1, Location2, Location3, Location4, Location5);
    }
}
