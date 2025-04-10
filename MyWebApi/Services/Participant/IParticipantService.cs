using MyWebApi.Dtos;

namespace MyWebApi.Services;

public interface IParticipantService
{
    Task<ParticipantDto> CreateParticipantAsync(ParticipantRequestDto request);
    Task<ParticipantDto?> UpdateParticipantAsync(Guid id, ParticipantRequestDto request);
    Task<bool> DeleteParticipantAsync(Guid id);
    Task<ParticipantDto?> GetParticipantByIdAsync(Guid id);
    Task<IEnumerable<ParticipantDto>> GetAllParticipantsAsync();
    Task<IEnumerable<ParticipantEventResponseDto>> GetParticipantEventsAsync(Guid participantId);
}
