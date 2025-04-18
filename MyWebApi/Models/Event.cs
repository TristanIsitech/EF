using MyWebApi.Enums;

namespace MyWebApi.Models;

public class Event
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public EventStatus Status { get; set; }
    public EventCategory Category { get; set; }
    public Guid LocationId { get; set; }
    public Location? Location { get; set; }
    public ICollection<EventParticipant> EventParticipants { get; set; } = new List<EventParticipant>();
    public ICollection<Session> Sessions { get; set; } = new List<Session>();
}
