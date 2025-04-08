namespace MyWebApi.Models;

public class Participant
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public string? Company { get; set; }
    public string? JobTitle { get; set; }
    public ICollection<EventParticipant> EventParticipants { get; set; }
    public ICollection<Rating> Ratings { get; set; }
}
