using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyWebApi.Models;

public class RatingConfiguration : IEntityTypeConfiguration<Rating>
{
    public void Configure(EntityTypeBuilder<Rating> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Score).IsRequired();
        builder.HasOne(r => r.Session)
            .WithMany(s => s.Ratings)
            .HasForeignKey(r => r.SessionId);
        builder.HasOne(r => r.Participant)
            .WithMany(p => p.Ratings)
            .HasForeignKey(r => r.ParticipantId);
    }
}
