// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwind.EFCore.Data;

namespace Northwind.EFCore.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210911152626_Region")]
    partial class Region
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Northwind.EFCore.Models.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT(11)");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("RegionID");

                    b.ToTable("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
