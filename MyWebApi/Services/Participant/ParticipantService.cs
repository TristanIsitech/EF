using MyWebApi.Dtos;
using MyWebApi.Models;
using MyWebApi.Repositories;
using MyWebApi.Mappers;

namespace MyWebApi.Services;

public class ParticipantService : IParticipantService
{
    private readonly IParticipantRepository _participantRepository;

    public ParticipantService(IParticipantRepository participantRepository)
    {
        _participantRepository = participantRepository;
    }

    public async Task<ParticipantDto> CreateParticipantAsync(ParticipantRequestDto request)
    {
        var participant = request.ToEntity();
        await _participantRepository.AddAsync(participant);
        return participant.ToDto();
    }

    public async Task<ParticipantDto?> UpdateParticipantAsync(Guid id, ParticipantRequestDto request)
    {
        var participant = await _participantRepository.GetByIdAsync(id);
        if (participant == null) return null;

        participant.FirstName = request.FirstName;
        participant.LastName = request.LastName;
        participant.Email = request.Email;
        participant.Company = request.Company;
        participant.JobTitle = request.JobTitle;

        await _participantRepository.UpdateAsync(participant);
        return participant.ToDto();
    }

    public async Task<bool> DeleteParticipantAsync(Guid id)
    {
        var participant = await _participantRepository.GetByIdAsync(id);
        if (participant == null) return false;

        await _participantRepository.DeleteAsync(participant);
        return true;
    }

    public async Task<ParticipantDto?> GetParticipantByIdAsync(Guid id)
    {
        var participant = await _participantRepository.GetByIdAsync(id);
        return participant?.ToDto();
    }

    public async Task<IEnumerable<ParticipantDto>> GetAllParticipantsAsync()
    {
        var participants = await _participantRepository.GetAllAsync();
        return participants.Select(p => p.ToDto());
    }

    public async Task<IEnumerable<ParticipantEventResponseDto>> GetParticipantEventsAsync(Guid participantId)
    {
        return await _participantRepository.GetParticipantEventsAsync(participantId);
    }
}
