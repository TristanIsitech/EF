using MyWebApi.Models;

namespace MyWebApi.Dtos;

public class LocationDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public int Capacity { get; set; }

    public ICollection<Room> Rooms { get; set; } = new List<Room>();
    public ICollection<Event> Events { get; set; } = new List<Event>();
}

