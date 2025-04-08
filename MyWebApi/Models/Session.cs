namespace MyWebApi.Models;

public class Session
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Guid EventId { get; set; }
    public Event Event { get; set; }
    public Guid RoomId { get; set; }
    public Room Room { get; set; }
    public ICollection<SessionSpeaker> SessionSpeakers { get; set; }
    public ICollection<Rating> Ratings { get; set; }
}
