using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;
using MyWebApi.Enums;
using MyWebApi.SeedData;

namespace MyWebApi;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

    public DbSet<Event> Events { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<EventParticipant> EventParticipants { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Speaker> Speakers { get; set; }
    public DbSet<SessionSpeaker> SessionSpeakers { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Rating> Ratings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EventConfiguration());
        modelBuilder.ApplyConfiguration(new ParticipantConfiguration());
        modelBuilder.ApplyConfiguration(new EventParticipantConfiguration());
        modelBuilder.ApplyConfiguration(new SessionConfiguration());
        modelBuilder.ApplyConfiguration(new SpeakerConfiguration());
        modelBuilder.ApplyConfiguration(new SessionSpeakerConfiguration());
        modelBuilder.ApplyConfiguration(new LocationConfiguration());
        modelBuilder.ApplyConfiguration(new RoomConfiguration());
        modelBuilder.ApplyConfiguration(new RatingConfiguration());

        LocationSeedData.Seed(modelBuilder);
        EventSeedData.Seed(modelBuilder);
        ParticipantSeedData.Seed(modelBuilder);
        //EventParticipantSeedData.Seed(modelBuilder);
    }
}
