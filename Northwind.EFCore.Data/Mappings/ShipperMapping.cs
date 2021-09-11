using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class ShipperMapping : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.ToTable("Shippers");

            builder.HasKey(p => p.ShipperID);

            builder.Property(p => p.ShipperID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.CompanyName)
                .HasColumnType("VARCHAR(40)")
                .IsRequired();

            builder.Property(p => p.Phone)
                .HasColumnType("VARCHAR(24)")
                .IsRequired();
        }
    }
}
