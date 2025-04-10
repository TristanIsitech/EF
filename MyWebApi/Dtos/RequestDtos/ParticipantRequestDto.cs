namespace MyWebApi.Dtos;

public class ParticipantRequestDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string? Company { get; set; }
    public string? JobTitle { get; set; }
}
