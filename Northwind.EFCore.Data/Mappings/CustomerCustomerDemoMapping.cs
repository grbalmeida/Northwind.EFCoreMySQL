using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class CustomerCustomerDemoMapping : IEntityTypeConfiguration<CustomerCustomerDemo>
    {
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
        {
            builder.ToTable("CustomerCustomerDemo");

            builder.Property(p => p.CustomerID)
                .HasColumnType("VARCHAR(5)")
                .IsRequired();

            builder.Property(p => p.CustomerTypeID)
                .HasColumnType("VARCHAR(10)")
                .IsRequired();

            builder.HasKey(p => new { p.CustomerID, p.CustomerTypeID });

            builder.HasOne(p => p.Customer)
                .WithMany(p => p.CustomerDemos)
                .HasForeignKey(p => p.CustomerID)
                .HasConstraintName("FK_CustomerDemo_Customer")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.CustomerDemographics)
                .WithMany(p => p.CustomerDemos)
                .HasForeignKey(p => p.CustomerTypeID)
                .HasConstraintName("FK_CustomerDemo_CustomerDemographics")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
