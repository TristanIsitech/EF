namespace MyWebApi.Models;

public class Location
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public int Capacity { get; set; }
    public ICollection<Room> Rooms { get; set; }
    public ICollection<Event> Events { get; set; }
}
