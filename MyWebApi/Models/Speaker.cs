namespace MyWebApi.Models;

public class Speaker
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Bio { get; set; }
    public required string Email { get; set; }
    public string? Company { get; set; }
    public ICollection<SessionSpeaker> SessionSpeakers { get; set; }
}
