using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Repositories;

public class EventRepository : RepositoryCore<Event>, IEventRepository
{
    public EventRepository(ApiDbContext context) : base(context)
    {
    }

    public async Task<Event?> GetEventWithLocationAsync(Guid id)
    {
        return await _dbSet
            .Include(e => e.Location)
            .FirstOrDefaultAsync(e => e.Id == id);
    }
}
