using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(p => p.CustomerID);

            builder.Property(p => p.CustomerID)
                .HasColumnType("VARCHAR(5)")
                .IsRequired();

            builder.Property(p => p.CompanyName)
                .HasColumnType("VARCHAR(40)")
                .IsRequired();

            builder.Property(p => p.ContactName)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

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

            builder.HasIndex(p => p.CustomerID).IsUnique();
        }
    }
}
