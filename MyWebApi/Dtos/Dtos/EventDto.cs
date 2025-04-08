using MyWebApi.Enums;

namespace MyWebApi.Dtos;

public class EventDto
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public EventStatus Status { get; set; }
    public EventCategory Category { get; set; }
    public Guid LocationId { get; set; }
    public LocationDto? Location { get; set; }
}
