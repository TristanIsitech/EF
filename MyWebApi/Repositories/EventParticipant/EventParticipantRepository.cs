using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Repositories;

public class EventParticipantRepository : IEventParticipantRepository
{
    private readonly ApiDbContext _context;

    public EventParticipantRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(EventParticipant eventParticipant)
    {
        await _context.EventParticipants.AddAsync(eventParticipant);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(EventParticipant eventParticipant)
    {
        _context.EventParticipants.Update(eventParticipant);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(EventParticipant eventParticipant)
    {
        _context.EventParticipants.Remove(eventParticipant);
        await _context.SaveChangesAsync();
    }

    public async Task<EventParticipant?> GetByIdAsync(Guid eventId, Guid participantId)
    {
        return await _context.EventParticipants
            .FirstOrDefaultAsync(ep => ep.EventId == eventId && ep.ParticipantId == participantId);
    }

    public async Task<IEnumerable<EventParticipant>> GetAllAsync()
    {
        return await _context.EventParticipants.ToListAsync();
    }
}
