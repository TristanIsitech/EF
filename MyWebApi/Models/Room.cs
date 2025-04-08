namespace MyWebApi.Models;

public class Room
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public int Capacity { get; set; }
    public Guid LocationId { get; set; }
    public Location Location { get; set; }
    public ICollection<Session> Sessions { get; set; }
}
