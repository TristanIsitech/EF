using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Repositories;

public class LocationRepository : RepositoryCore<Location>, ILocationRepository
{
    public LocationRepository(ApiDbContext context) : base(context)
    {
    }

    public async Task<Location?> GetByNameAsync(string name)
    {
        return await _dbSet.FirstOrDefaultAsync(l => l.Name == name);
    }
}
