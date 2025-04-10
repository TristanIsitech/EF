namespace MyWebApi.Dtos;

public class EventParticipantRequestDto
{
    public Guid EventId { get; set; }
    public Guid ParticipantId { get; set; }
    public DateTime RegistrationDate { get; set; }
    public string? AttendanceStatus { get; set; }
}
