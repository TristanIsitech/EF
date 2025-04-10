using MyWebApi.Dtos;
using MyWebApi.Models;

namespace MyWebApi.Repositories;

public interface IParticipantRepository
{
    Task AddAsync(Participant participant);
    Task UpdateAsync(Participant participant);
    Task DeleteAsync(Participant participant);
    Task<Participant?> GetByIdAsync(Guid id);
    Task<IEnumerable<Participant>> GetAllAsync();
    Task<IEnumerable<ParticipantEventResponseDto>> GetParticipantEventsAsync(Guid participantId);
}
