using MyWebApi.Models;

namespace MyWebApi.Repositories;

public interface IEventRepository : IRepositoryCore<Event>
{
    Task<Event?> GetEventWithLocationAsync(Guid id);
}
