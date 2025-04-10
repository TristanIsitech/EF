using MyWebApi.Dtos;

namespace MyWebApi.Services;

public interface IEventParticipantService
{
    Task<EventParticipantDto> CreateEventParticipantAsync(EventParticipantRequestDto request);
    Task<EventParticipantDto?> UpdateEventParticipantAsync(Guid eventId, Guid participantId, EventParticipantRequestDto request);
    Task<bool> DeleteEventParticipantAsync(Guid eventId, Guid participantId);
    Task<EventParticipantDto?> GetEventParticipantByIdAsync(Guid eventId, Guid participantId);
    Task<IEnumerable<EventParticipantDto>> GetAllEventParticipantsAsync();
}
