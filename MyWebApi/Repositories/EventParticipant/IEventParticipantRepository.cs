using MyWebApi.Models;

namespace MyWebApi.Repositories;

public interface IEventParticipantRepository
{
    Task AddAsync(EventParticipant eventParticipant);
    Task UpdateAsync(EventParticipant eventParticipant);
    Task DeleteAsync(EventParticipant eventParticipant);
    Task<EventParticipant?> GetByIdAsync(Guid eventId, Guid participantId);
    Task<IEnumerable<EventParticipant>> GetAllAsync();
}
