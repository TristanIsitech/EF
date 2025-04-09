using MyWebApi.Models;
using Microsoft.EntityFrameworkCore;
using MyWebApi.SeedData;
using Microsoft.Extensions.Logging;

namespace MyWebApi.SeedData;

public static class EventParticipantSeedData
{
    //public static readonly EventParticipant EventParticipant1 = new EventParticipant
    //{
    //    EventId = EventSeedData.Event1.Id, 
    //    ParticipantId = ParticipantSeedData.Participant1.Id, 
    //    RegistrationDate = DateTime.UtcNow.AddDays(-10),
    //    AttendanceStatus = "Confirmed"
    //};

    //public static readonly EventParticipant EventParticipant2 = new EventParticipant
    //{
    //    EventId = EventSeedData.Event2.Id,
    //    ParticipantId = ParticipantSeedData.Participant2.Id,
    //    RegistrationDate = DateTime.UtcNow.AddDays(-9),
    //    AttendanceStatus = "Pending"
    //};

    //public static readonly EventParticipant EventParticipant3 = new EventParticipant
    //{
    //    EventId = EventSeedData.Event3.Id,
    //    ParticipantId = ParticipantSeedData.Participant3.Id,
    //    RegistrationDate = DateTime.UtcNow.AddDays(-8),
    //    AttendanceStatus = "Confirmed"
    //};

    //public static readonly EventParticipant EventParticipant4 = new EventParticipant
    //{
    //    EventId = EventSeedData.Event4.Id,
    //    ParticipantId = ParticipantSeedData.Participant4.Id,
    //    RegistrationDate = DateTime.UtcNow.AddDays(-7),
    //    AttendanceStatus = "Cancelled"
    //};

    //public static readonly EventParticipant EventParticipant5 = new EventParticipant
    //{
    //    EventId = EventSeedData.Event5.Id,
    //    ParticipantId = ParticipantSeedData.Participant5.Id,
    //    RegistrationDate = DateTime.UtcNow.AddDays(-6),
    //    AttendanceStatus = "Confirmed"
    //};

    //public static void Seed(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<EventParticipant>().HasData(
    //        EventParticipant1,
    //        EventParticipant2,
    //        EventParticipant3,
    //        EventParticipant4,
    //        EventParticipant5
    //    );
    //}
}
