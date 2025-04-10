using MyWebApi.Dtos;
using MyWebApi.Models;
using MyWebApi.Repositories;
using MyWebApi.Mappers;

namespace MyWebApi.Services;

public class EventParticipantService : IEventParticipantService
{
    private readonly IEventParticipantRepository _eventParticipantRepository;

    public EventParticipantService(IEventParticipantRepository eventParticipantRepository)
    {
        _eventParticipantRepository = eventParticipantRepository;
    }

    public async Task<EventParticipantDto> CreateEventParticipantAsync(EventParticipantRequestDto request)
    {
        var eventParticipant = request.ToEntity();
        await _eventParticipantRepository.AddAsync(eventParticipant);
        return eventParticipant.ToDto();
    }

    public async Task<EventParticipantDto?> UpdateEventParticipantAsync(Guid eventId, Guid participantId, EventParticipantRequestDto request)
    {
        var eventParticipant = await _eventParticipantRepository.GetByIdAsync(eventId, participantId);
        if (eventParticipant == null) return null;

        eventParticipant.RegistrationDate = request.RegistrationDate;
        eventParticipant.AttendanceStatus = request.AttendanceStatus;

        await _eventParticipantRepository.UpdateAsync(eventParticipant);
        return eventParticipant.ToDto();
    }

    public async Task<bool> DeleteEventParticipantAsync(Guid eventId, Guid participantId)
    {
        var eventParticipant = await _eventParticipantRepository.GetByIdAsync(eventId, participantId);
        if (eventParticipant == null) return false;

        await _eventParticipantRepository.DeleteAsync(eventParticipant);
        return true;
    }

    public async Task<EventParticipantDto?> GetEventParticipantByIdAsync(Guid eventId, Guid participantId)
    {
        var eventParticipant = await _eventParticipantRepository.GetByIdAsync(eventId, participantId);
        return eventParticipant?.ToDto();
    }

    public async Task<IEnumerable<EventParticipantDto>> GetAllEventParticipantsAsync()
    {
        var eventParticipants = await _eventParticipantRepository.GetAllAsync();
        return eventParticipants.Select(ep => ep.ToDto());
    }
}
