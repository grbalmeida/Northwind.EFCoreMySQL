using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class TerritoryMapping : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.ToTable("Territories");

            builder.HasKey(p => p.TerritoryID);

            builder.Property(p => p.TerritoryID)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();

            builder.Property(p => p.TerritoryDescription)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder.Property(p => p.RegionID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.HasOne(p => p.Region)
                .WithMany(p => p.Territories)
                .HasForeignKey(p => p.RegionID)
                .HasConstraintName("FK_Region")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(p => p.TerritoryID).IsUnique();

            builder.HasIndex(p => p.TerritoryDescription).IsUnique();
        }
    }
}
