using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class CustomerDemographicsMapping : IEntityTypeConfiguration<CustomerDemographics>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographics> builder)
        {
            builder.ToTable("CustomerDemographics");

            builder.HasKey(p => p.CustomerTypeID);

            builder.Property(p => p.CustomerTypeID)
                .HasColumnType("VARCHAR(10)")
                .IsRequired();

            builder.Property(p => p.CustomerDesc)
                .HasColumnType("MEDIUMTEXT")
                .IsRequired();
        }
    }
}
