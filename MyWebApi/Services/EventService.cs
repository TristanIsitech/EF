using MyWebApi.Models;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Dtos;

namespace MyWebApi.Services;

public class EventService
{
    private readonly ApiDbContext _context;

    public EventService(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<EventDto> CreateEventAsync(EventRequestDto request)
    {
        // Utilisation du mapper pour convertir le DTO en modèle
        var newEvent = EventMapper.ToModel(request);
        newEvent.Id = Guid.NewGuid(); // Génération de l'ID

        _context.Events.Add(newEvent);
        await _context.SaveChangesAsync();

        // Utilisation du mapper pour convertir le modèle en DTO
        var location = await _context.Locations.FindAsync(newEvent.LocationId);
        newEvent.Location = location; // Charger la relation si nécessaire
        return EventMapper.ToDto(newEvent);
    }

    public async Task<EventDto?> UpdateEventAsync(Guid id, EventRequestDto request)
    {
        var existingEvent = await _context.Events.FindAsync(id);
        if (existingEvent == null) return null;

        // Mise à jour des propriétés via le mapper
        var updatedEvent = EventMapper.ToModel(request);
        existingEvent.Title = updatedEvent.Title;
        existingEvent.Description = updatedEvent.Description;
        existingEvent.StartDate = updatedEvent.StartDate;
        existingEvent.EndDate = updatedEvent.EndDate;
        existingEvent.Status = updatedEvent.Status;
        existingEvent.Category = updatedEvent.Category;
        existingEvent.LocationId = updatedEvent.LocationId;

        await _context.SaveChangesAsync();

        // Utilisation du mapper pour convertir le modèle en DTO
        var location = await _context.Locations.FindAsync(existingEvent.LocationId);
        existingEvent.Location = location; // Charger la relation si nécessaire
        return EventMapper.ToDto(existingEvent);
    }

    public async Task<bool> DeleteEventAsync(Guid id)
    {
        var existingEvent = await _context.Events.FindAsync(id);
        if (existingEvent == null) return false;

        _context.Events.Remove(existingEvent);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<EventDto?> GetEventByIdAsync(Guid id)
    {
        var eventModel = await _context.Events
            .Include(e => e.Location) // Charger la relation Location
            .FirstOrDefaultAsync(e => e.Id == id);

        if (eventModel == null) return null;

        return EventMapper.ToDto(eventModel);
    }
}
