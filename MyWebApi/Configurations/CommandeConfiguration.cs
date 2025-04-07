using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyWebApi.Models;

public class CommandeConfiguration : IEntityTypeConfiguration<Commande>
{
    public void Configure(EntityTypeBuilder<Commande> builder)
    {
        // Cl� primaire
        builder.HasKey(co => co.Id);

        // Propri�t�s
        builder.Property(co => co.OrderDate)
            .IsRequired();

        // Relations
        builder.HasOne(co => co.Client)
            .WithMany(c => c.Commandes)
            .HasForeignKey(co => co.ClientId);

        builder.HasMany(co => co.Products)
            .WithMany(p => p.Commandes)
            .UsingEntity(j => j.ToTable("CommandeProducts")); // Ajout de la table de jonction
    }
}
