using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class RegionMapping : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Region");

            builder.HasKey(p => p.RegionID);

            builder.Property(p => p.RegionID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.RegionDescription)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();
        }
    }
}
