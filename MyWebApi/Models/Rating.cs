namespace MyWebApi.Models;

public class Rating
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public Session Session { get; set; }
    public Guid ParticipantId { get; set; }
    public Participant Participant { get; set; }
    public int Score { get; set; }
    public string? Comment { get; set; }
}
