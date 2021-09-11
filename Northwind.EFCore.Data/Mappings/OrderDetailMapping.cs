using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class OrderDetailMapping : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");

            builder.Property(p => p.OrderID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.ProductID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.UnitPrice)
                .HasColumnType("DECIMAL(10, 4)")
                .IsRequired();

            builder.Property(p => p.Quantity)
                .HasColumnType("SMALLINT(2)")
                .IsRequired();

            builder.Property(p => p.Discount)
                .HasColumnType("DOUBLE(8, 0)")
                .IsRequired();

            builder.HasKey(p => new { p.OrderID, p.ProductID });

            builder.HasOne(p => p.Order)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.OrderID)
                .HasConstraintName("FK_Order")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.ProductID)
                .HasConstraintName("FK_Product")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
