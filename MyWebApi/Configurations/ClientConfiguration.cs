using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyWebApi.Models;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        // Clé primaire
        builder.HasKey(c => c.Id);

        // Propriétés
        builder.Property(c => c.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(100);

        // Relations
        builder.HasOne(c => c.Adresse)
            .WithMany(a => a.Clients)
            .HasForeignKey(c => c.AdresseId);

        builder.HasMany(c => c.Commandes)
            .WithOne(co => co.Client)
            .HasForeignKey(co => co.ClientId);
    }
}
