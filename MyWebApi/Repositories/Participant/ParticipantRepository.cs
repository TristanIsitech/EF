using Microsoft.EntityFrameworkCore;
using MyWebApi.Dtos;
using MyWebApi.Models;

namespace MyWebApi.Repositories;

public class ParticipantRepository : IParticipantRepository
{
    private readonly ApiDbContext _context;

    public ParticipantRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Participant participant)
    {
        await _context.Participants.AddAsync(participant);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Participant participant)
    {
        _context.Participants.Update(participant);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Participant participant)
    {
        _context.Participants.Remove(participant);
        await _context.SaveChangesAsync();
    }

    public async Task<Participant?> GetByIdAsync(Guid id)
    {
        return await _context.Participants.FindAsync(id);
    }

    public async Task<IEnumerable<Participant>> GetAllAsync()
    {
        return await _context.Participants.ToListAsync();
    }

    public async Task<IEnumerable<ParticipantEventResponseDto>> GetParticipantEventsAsync(Guid participantId)
    {
        return await _context.EventParticipants
            .Where(ep => ep.ParticipantId == participantId)
            .Select(ep => new ParticipantEventResponseDto
            {
                EventId = ep.EventId,
                EventTitle = ep.Event.Title,
                LocationName = ep.Event.Location.Name,
                LocationCity = ep.Event.Location.City,
                ParticipantCount = _context.EventParticipants.Count(e => e.EventId == ep.EventId)
            })
            .ToListAsync();
    }
}
