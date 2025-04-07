using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyWebApi.Models;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // Clé primaire
        builder.HasKey(p => p.Id);

        // Propriétés
        builder.Property(p => p.Name)
            .IsRequired();

        builder.Property(p => p.Description)
            .IsRequired();

        builder.Property(p => p.Price)
            .IsRequired();

        builder.Property(p => p.CreatedAt)
            .IsRequired();

        builder.Property(p => p.IsAvailable)
            .IsRequired();

        // Relations
        builder.HasMany(p => p.Commandes)
            .WithMany(co => co.Products)
            .UsingEntity(j => j.ToTable("CommandeProducts")); // Ajout de la table de jonction
    }
}
