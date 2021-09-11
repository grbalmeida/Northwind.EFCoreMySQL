using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.ProductID);

            builder.Property(p => p.ProductID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.ProductName)
                .HasColumnType("VARCHAR(40)")
                .IsRequired();

            builder.Property(p => p.SupplierID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.CategoryID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.QuantityPerUnit)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();

            builder.Property(p => p.UnitPrice)
                .HasColumnType("DECIMAL(10, 4)")
                .IsRequired();

            builder.Property(p => p.UnitsInStock)
                .HasColumnType("SMALLINT(2)")
                .IsRequired();

            builder.Property(p => p.UnitsOnOrder)
                .HasColumnType("SMALLINT(2)")
                .IsRequired();

            builder.Property(p => p.ReorderLevel)
                .HasColumnType("SMALLINT(2)")
                .IsRequired();

            builder.Property(p => p.Discontinued)
                .HasColumnType("BIT")
                .IsRequired();

            builder.HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryID)
                .HasConstraintName("FK_Category")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Supplier)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.SupplierID)
                .HasConstraintName("FK_Supplier")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
