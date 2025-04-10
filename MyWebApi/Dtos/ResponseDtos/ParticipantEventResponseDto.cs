namespace MyWebApi.Dtos;

public class ParticipantEventResponseDto
{
    public Guid EventId { get; set; }
    public string EventTitle { get; set; }
    public string LocationName { get; set; }
    public string LocationCity { get; set; }
    public int ParticipantCount { get; set; }
}
