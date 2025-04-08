namespace MyWebApi.Models;

public class EventParticipant
{
    public Guid EventId { get; set; }
    public Event Event { get; set; }
    public Guid ParticipantId { get; set; }
    public Participant Participant { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string AttendanceStatus { get; set; }
}
