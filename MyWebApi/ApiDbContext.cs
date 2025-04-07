using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace IsiHostAPI.Persistence;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } 
}
