using MyWebApi.Models;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Dtos;
using MyWebApi.Repositories;

namespace MyWebApi.Services;

public class EventService : IEventService
{
    private readonly IEventRepository _eventRepository;

    public EventService(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }

    public async Task<EventDto> CreateEventAsync(EventRequestDto request)
    {
        var newEvent = EventMapper.ToModel(request);
        newEvent.Id = Guid.NewGuid();

        await _eventRepository.AddAsync(newEvent);
        await _eventRepository.SaveChangesAsync();

        var eventWithLocation = await _eventRepository.GetEventWithLocationAsync(newEvent.Id);
        return EventMapper.ToDto(eventWithLocation!);
    }

    public async Task<EventDto?> UpdateEventAsync(Guid id, EventRequestDto request)
    {
        var existingEvent = await _eventRepository.GetByIdAsync(id);
        if (existingEvent == null) return null;

        existingEvent.Title = request.Title;
        existingEvent.Description = request.Description;
        existingEvent.StartDate = request.StartDate;
        existingEvent.EndDate = request.EndDate;
        existingEvent.Status = request.Status;
        existingEvent.Category = request.Category;
        existingEvent.LocationId = request.LocationId;

        _eventRepository.Update(existingEvent);
        await _eventRepository.SaveChangesAsync();

        var updatedEvent = await _eventRepository.GetEventWithLocationAsync(id);
        return EventMapper.ToDto(updatedEvent!);
    }

    public async Task<bool> DeleteEventAsync(Guid id)
    {
        var existingEvent = await _eventRepository.GetByIdAsync(id);
        if (existingEvent == null) return false;

        _eventRepository.Remove(existingEvent);
        await _eventRepository.SaveChangesAsync();
        return true;
    }

    public async Task<EventDto?> GetEventByIdAsync(Guid id)
    {
        var eventWithLocation = await _eventRepository.GetEventWithLocationAsync(id);
        if (eventWithLocation == null) return null;

        return EventMapper.ToDto(eventWithLocation);
    }
}
