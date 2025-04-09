using MyWebApi.Models;
using MyWebApi.Enums;
using Microsoft.EntityFrameworkCore;

namespace MyWebApi.SeedData;

public static class EventSeedData
{
    public static readonly Event Event1 = new Event
    {
        Id = Guid.NewGuid(),
        Title = "Conférence Tech 2024",
        Description = "Une conférence sur les dernières technologies.",
        StartDate = DateTime.UtcNow.AddDays(10),
        EndDate = DateTime.UtcNow.AddDays(12),
        Status = EventStatus.EnCours,
        Category = EventCategory.Conférence,
        LocationId = LocationSeedData.Location1.Id
    };

    public static readonly Event Event2 = new Event
    {
        Id = Guid.NewGuid(),
        Title = "Festival de Musique",
        Description = "Un festival avec des artistes internationaux.",
        StartDate = DateTime.UtcNow.AddDays(20),
        EndDate = DateTime.UtcNow.AddDays(22),
        Status = EventStatus.Disponible,
        Category = EventCategory.Festival,
        LocationId = LocationSeedData.Location2.Id
    };

    public static readonly Event Event3 = new Event
    {
        Id = Guid.NewGuid(),
        Title = "Exposition d'Art Moderne",
        Description = "Une exposition mettant en avant des artistes contemporains.",
        StartDate = DateTime.UtcNow.AddDays(5),
        EndDate = DateTime.UtcNow.AddDays(15),
        Status = EventStatus.BientotDisponible,
        Category = EventCategory.Exposition,
        LocationId = LocationSeedData.Location3.Id
    };

    public static readonly Event Event4 = new Event
    {
        Id = Guid.NewGuid(),
        Title = "Atelier de Programmation",
        Description = "Un atelier pour apprendre les bases de la programmation.",
        StartDate = DateTime.UtcNow.AddDays(30),
        EndDate = DateTime.UtcNow.AddDays(31),
        Status = EventStatus.LibreAcces,
        Category = EventCategory.Atelier,
        LocationId = LocationSeedData.Location4.Id
    };

    public static readonly Event Event5 = new Event
    {
        Id = Guid.NewGuid(),
        Title = "Gala de Charité",
        Description = "Un gala pour collecter des fonds pour une bonne cause.",
        StartDate = DateTime.UtcNow.AddDays(40),
        EndDate = DateTime.UtcNow.AddDays(41),
        Status = EventStatus.Complet,
        Category = EventCategory.Gala,
        LocationId = LocationSeedData.Location5.Id
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>().HasData(Event1, Event2, Event3, Event4, Event5);
    }
}
