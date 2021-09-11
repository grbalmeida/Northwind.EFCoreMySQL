using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(p => p.OrderID);

            builder.Property(p => p.OrderID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.CustomerID)
                .HasColumnType("VARCHAR(5)")
                .IsRequired();

            builder.Property(p => p.EmployeeID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.OrderDate)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(p => p.RequiredDate)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(p => p.ShippedDate)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(p => p.ShipVia)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.Freight)
                .HasColumnType("DECIMAL(10, 4)")
                .IsRequired();

            builder.Property(p => p.ShipName)
                .HasColumnType("VARCHAR(40)")
                .IsRequired();

            builder.Property(p => p.ShipAddress)
                .HasColumnType("VARCHAR(60)")
                .IsRequired();

            builder.Property(p => p.ShipCity)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();

            builder.Property(p => p.ShipRegion)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();

            builder.Property(p => p.ShipPostalCode)
                .HasColumnType("VARCHAR(10)")
                .IsRequired();

            builder.Property(p => p.ShipCountry)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();

            builder.HasOne(p => p.Customer)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.CustomerID)
                .HasConstraintName("FK_Customer")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Employee)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.EmployeeID)
                .HasConstraintName("FK_Employee")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Shipper)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.ShipVia)
                .HasConstraintName("FK_Shipper")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
