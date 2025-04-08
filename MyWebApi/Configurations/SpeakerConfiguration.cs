using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyWebApi.Models;

public class SpeakerConfiguration : IEntityTypeConfiguration<Speaker>
{
    public void Configure(EntityTypeBuilder<Speaker> builder)
    {
        builder.HasKey(sp => sp.Id);
        builder.Property(sp => sp.FirstName).IsRequired();
        builder.Property(sp => sp.LastName).IsRequired();
        builder.Property(sp => sp.Email).IsRequired();
    }
}
