using MyWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MyWebApi.SeedData;

public static class ParticipantSeedData
{
    public static readonly Participant Participant1 = new Participant
    {
        Id = Guid.NewGuid(),
        FirstName = "Alice",
        LastName = "Dupont",
        Email = "alice.dupont@example.com",
        Company = "TechCorp",
        JobTitle = "Développeuse"
    };

    public static readonly Participant Participant2 = new Participant
    {
        Id = Guid.NewGuid(),
        FirstName = "Bob",
        LastName = "Martin",
        Email = "bob.martin@example.com",
        Company = "MusicWorld",
        JobTitle = "Producteur"
    };

    public static readonly Participant Participant3 = new Participant
    {
        Id = Guid.NewGuid(),
        FirstName = "Charlie",
        LastName = "Durand",
        Email = "charlie.durand@example.com",
        Company = "ArtExpo",
        JobTitle = "Curateur"
    };

    public static readonly Participant Participant4 = new Participant
    {
        Id = Guid.NewGuid(),
        FirstName = "Diane",
        LastName = "Moreau",
        Email = "diane.moreau@example.com",
        Company = "CodeAcademy",
        JobTitle = "Formatrice"
    };

    public static readonly Participant Participant5 = new Participant
    {
        Id = Guid.NewGuid(),
        FirstName = "Eve",
        LastName = "Lemoine",
        Email = "eve.lemoine@example.com",
        Company = "CharityOrg",
        JobTitle = "Organisatrice"
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Participant>().HasData(Participant1, Participant2, Participant3, Participant4, Participant5);
    }
}
