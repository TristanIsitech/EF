namespace MyWebApi.Dtos;

public class LocationRequestDto
{
    public required string Name { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public int Capacity { get; set; }
}
