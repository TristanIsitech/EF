namespace MyWebApi.Models;

public class SessionSpeaker
{
    public Guid SessionId { get; set; }
    public Session Session { get; set; }
    public Guid SpeakerId { get; set; }
    public Speaker Speaker { get; set; }
    public string Role { get; set; }
}
