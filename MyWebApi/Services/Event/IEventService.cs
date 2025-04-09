using MyWebApi.Dtos;

namespace MyWebApi.Services;

public interface IEventService
{
    Task<EventDto> CreateEventAsync(EventRequestDto request);
    Task<EventDto?> UpdateEventAsync(Guid id, EventRequestDto request);
    Task<bool> DeleteEventAsync(Guid id);
    Task<EventDto?> GetEventByIdAsync(Guid id);
}
