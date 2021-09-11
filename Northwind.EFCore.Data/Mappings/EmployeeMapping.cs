using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.EFCore.Models;

namespace Northwind.EFCore.Data.Mappings
{
    public class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(p => p.EmployeeID);

            builder.Property(p => p.EmployeeID)
                .HasColumnType("INT(11)")
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();

            builder.Property(p => p.FirstName)
                .HasColumnType("VARCHAR(10)")
                .IsRequired();

            builder.Property(p => p.Title)
                .HasColumnType("VARCHAR(30)");

            builder.Property(p => p.TitleOfCourtesy)
                .HasColumnType("VARCHAR(25)");

            builder.Property(p => p.BirthDate)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(p => p.HireDate)
                .HasColumnType("DATETIME")
                .IsRequired();

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

            builder.Property(p => p.HomePhone)
                .HasColumnType("VARCHAR(24)");

            builder.Property(p => p.Extension)
                .HasColumnType("VARCHAR(4)");

            builder.Property(p => p.Notes)
                .HasColumnType("MEDIUMTEXT")
                .IsRequired();

            builder.Property(p => p.ReportsTo)
                .HasColumnType("INT(11)");

            builder.Property(p => p.PhotoPath)
                .HasColumnType("VARCHAR(255)")
                .IsRequired();

            builder.Property(p => p.Salary)
                .HasColumnType("FLOAT")
                .IsRequired();

            builder.HasOne(p => p.Manager)
                .WithMany(p => p.Underlings)
                .HasForeignKey(p => p.ReportsTo)
                .HasConstraintName("FK_Manager")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
