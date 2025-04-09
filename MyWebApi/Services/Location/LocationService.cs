using MyWebApi.Dtos;
using MyWebApi.Models;
using MyWebApi.Repositories;

namespace MyWebApi.Services;

public class LocationService : ILocationService
{
    private readonly ILocationRepository _locationRepository;

    public LocationService(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }

    public async Task<LocationDto> CreateLocationAsync(LocationRequestDto request)
    {
        var newLocation = LocationMapper.ToModel(request);

        newLocation.Id = Guid.NewGuid();
        await _locationRepository.AddAsync(newLocation);
        await _locationRepository.SaveChangesAsync();

        return LocationMapper.ToDto(newLocation);
    }

    public async Task<LocationDto?> UpdateLocationAsync(Guid id, LocationRequestDto request)
    {
        var existingLocation = await _locationRepository.GetByIdAsync(id);
        if (existingLocation == null) return null;

        existingLocation.Name = request.Name;
        existingLocation.Address = request.Address;
        existingLocation.City = request.City;
        existingLocation.Country = request.Country;
        existingLocation.Capacity = request.Capacity;

        _locationRepository.Update(existingLocation);
        await _locationRepository.SaveChangesAsync();

        return LocationMapper.ToDto(existingLocation);
    }

    public async Task<bool> DeleteLocationAsync(Guid id)
    {
        var existingLocation = await _locationRepository.GetByIdAsync(id);
        if (existingLocation == null) return false;

        _locationRepository.Remove(existingLocation);
        await _locationRepository.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<LocationDto>> GetAllLocationsAsync()
    {
        var locations = await _locationRepository.GetAllAsync();
        return locations.Select(LocationMapper.ToDto);
    }

    public async Task<LocationDto?> GetLocationByIdAsync(Guid id)
    {
        var location = await _locationRepository.GetByIdAsync(id);
        if (location == null) return null;

        return LocationMapper.ToDto(location);
    }

    public async Task<LocationDto?> GetLocationByNameAsync(string name)
    {
        var location = await _locationRepository.GetByNameAsync(name);
        if (location == null) return null;

        return LocationMapper.ToDto(location);
    }
}
