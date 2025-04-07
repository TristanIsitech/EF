using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyWebApi.Models;

public class AdresseConfiguration : IEntityTypeConfiguration<Adresse>
{
    public void Configure(EntityTypeBuilder<Adresse> builder)
    {
        // Cl� primaire
        builder.HasKey(a => a.Id);

        // Propri�t�s
        builder.Property(a => a.Street)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.City)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(a => a.PostalCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(a => a.Country)
            .IsRequired()
            .HasMaxLength(50);
    }
}
