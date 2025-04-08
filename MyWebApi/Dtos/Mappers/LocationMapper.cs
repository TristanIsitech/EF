// Dtos/Mappers/LocationMapper.cs
using MyWebApi.Dtos;
using MyWebApi.Models;

namespace MyWebApi.Dtos;

public static class LocationMapper
{
    public static LocationDto ToDto(Location model)
    {
        return new LocationDto
        {
            Id = model.Id,
            Name = model.Name,
            Address = model.Address,
            City = model.City,
            Country = model.Country,
            Capacity = model.Capacity
        };
    }

    public static Location ToModel(LocationDto dto)
    {
        return new Location
        {
            Id = dto.Id,
            Name = dto.Name,
            Address = dto.Address,
            City = dto.City,
            Country = dto.Country,
            Capacity = dto.Capacity
        };
    }
}

