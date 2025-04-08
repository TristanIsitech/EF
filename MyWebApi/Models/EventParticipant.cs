namespace MyWebApi.Models;

public class EventParticipant
{
    public Guid EventId { get; set; }
    public required Event Event { get; set; }
    public Guid ParticipantId { get; set; }
    public required Participant Participant { get; set; } 
    public DateTime RegistrationDate { get; set; }
    public string? AttendanceStatus { get; set; }
}
