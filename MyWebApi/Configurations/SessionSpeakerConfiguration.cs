using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyWebApi.Models;

public class SessionSpeakerConfiguration : IEntityTypeConfiguration<SessionSpeaker>
{
    public void Configure(EntityTypeBuilder<SessionSpeaker> builder)
    {
        builder.HasKey(ss => new { ss.SessionId, ss.SpeakerId });
        builder.HasOne(ss => ss.Session)
            .WithMany(s => s.SessionSpeakers)
            .HasForeignKey(ss => ss.SessionId);
        builder.HasOne(ss => ss.Speaker)
            .WithMany(sp => sp.SessionSpeakers)
            .HasForeignKey(ss => ss.SpeakerId);
    }
}
