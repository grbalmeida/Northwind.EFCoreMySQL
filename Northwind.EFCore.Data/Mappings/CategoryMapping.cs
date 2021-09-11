using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(p => p.CategoryID);

            builder.Property(p => p.CategoryID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.CategoryName)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("MEDIUMTEXT");

            builder.HasIndex(p => p.CategoryName).IsUnique();
        }
    }
}
