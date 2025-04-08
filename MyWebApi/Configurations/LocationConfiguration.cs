using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyWebApi.Models;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Name).IsRequired();
        builder.Property(l => l.Address).IsRequired();
        builder.Property(l => l.City).IsRequired();
        builder.Property(l => l.Country).IsRequired();
    }
}
