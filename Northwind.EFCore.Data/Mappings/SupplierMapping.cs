using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Suppliers");

            builder.HasKey(p => p.SupplierID);

            builder.Property(p => p.SupplierID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.CompanyName)
                .HasColumnType("VARCHAR(40)")
                .IsRequired();

            builder.Property(p => p.ContactName)
                .HasColumnType("VARCHAR(30)");

            builder.Property(p => p.ContactTitle)
                .HasColumnType("VARCHAR(30)");

            builder.Property(p => p.Address)
                .HasColumnType("VARCHAR(60)")
                .IsRequired();

            builder.Property(p => p.City)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();

            builder.Property(p => p.Region)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();

            builder.Property(p => p.PostalCode)
                .HasColumnType("VARCHAR(10)")
                .IsRequired();

            builder.Property(p => p.Country)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();

            builder.Property(p => p.Phone)
                .HasColumnType("VARCHAR(24)")
                .IsRequired();

            builder.Property(p => p.Fax)
                .HasColumnType("VARCHAR(24)");

            builder.Property(p => p.HomePage)
                .HasColumnType("MEDIUMTEXT");
        }
    }
}
