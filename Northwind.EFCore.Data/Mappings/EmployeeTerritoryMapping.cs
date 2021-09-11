using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class EmployeeTerritoryMapping : IEntityTypeConfiguration<EmployeeTerritory>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritory> builder)
        {
            builder.ToTable("EmployeeTerritories");

            builder.Property(p => p.EmployeeID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.TerritoryID)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();

            builder.HasKey(p => new { p.EmployeeID, p.TerritoryID });

            builder.HasOne(p => p.Employee)
                .WithMany(p => p.EmployeeTerritories)
                .HasForeignKey(p => p.EmployeeID)
                .HasConstraintName("FK_EmployeeTerritory_Employee")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Territory)
                .WithMany(p => p.EmployeeTerritories)
                .HasForeignKey(p => p.TerritoryID)
                .HasConstraintName("FK_EmployeeTerritory_Territory")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
