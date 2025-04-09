using MyWebApi.Dtos;

namespace MyWebApi.Services;

public interface ILocationService
{
    Task<LocationDto> CreateLocationAsync(LocationRequestDto request);
    Task<LocationDto?> UpdateLocationAsync(Guid id, LocationRequestDto request);
    Task<bool> DeleteLocationAsync(Guid id);
    Task<IEnumerable<LocationDto>> GetAllLocationsAsync();
    Task<LocationDto?> GetLocationByIdAsync(Guid id);
    Task<LocationDto?> GetLocationByNameAsync(string name);
}
