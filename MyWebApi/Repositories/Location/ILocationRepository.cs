using MyWebApi.Models;

namespace MyWebApi.Repositories;

public interface ILocationRepository : IRepositoryCore<Location>
{
    Task<Location?> GetByNameAsync(string name);
}
