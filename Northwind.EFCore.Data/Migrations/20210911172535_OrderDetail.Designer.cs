﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Northwind.EFCore.Data;

namespace Northwind.EFCore.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210911172535_OrderDetail")]
    partial class OrderDetail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Northwind.EFCore.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT(11)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Description")
                        .HasColumnType("MEDIUMTEXT");

                    b.HasKey("CategoryID");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("VARCHAR(5)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Fax")
                        .HasColumnType("VARCHAR(24)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.HasKey("CustomerID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.CustomerDemographics", b =>
                {
                    b.Property<string>("CustomerTypeID")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("CustomerDesc")
                        .IsRequired()
                        .HasColumnType("MEDIUMTEXT");

                    b.HasKey("CustomerTypeID");

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT(11)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Extension")
                        .HasColumnType("VARCHAR(4)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("HomePhone")
                        .HasColumnType("VARCHAR(24)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("MEDIUMTEXT");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("INT(11)");

                    b.Property<float>("Salary")
                        .HasColumnType("FLOAT");

                    b.Property<string>("Title")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("TitleOfCourtesy")
                        .HasColumnType("VARCHAR(25)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT(11)");

                    b.Property<string>("CustomerID")
                        .IsRequired()
                        .HasColumnType("VARCHAR(5)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("INT(11)");

                    b.Property<decimal>("Freight")
                        .HasColumnType("DECIMAL(10, 4)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<int>("ShipVia")
                        .HasColumnType("INT(11)");

                    b.Property<DateTime?>("ShippedDate")
                        .IsRequired()
                        .HasColumnType("DATETIME");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShipVia");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("INT(11)");

                    b.Property<int>("ProductID")
                        .HasColumnType("INT(11)");

                    b.Property<double>("Discount")
                        .HasColumnType("DOUBLE(8, 0 )");

                    b.Property<short>("Quantity")
                        .HasColumnType("SMALLINT(2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("DECIMAL(10, 4)");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT(11)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INT(11)");

                    b.Property<ulong>("Discontinued")
                        .HasColumnType("BIT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("QuantityPerUnit")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<short>("ReorderLevel")
                        .HasColumnType("SMALLINT(2)");

                    b.Property<int>("SupplierID")
                        .HasColumnType("INT(11)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("DECIMAL(10, 4)");

                    b.Property<short>("UnitsInStock")
                        .HasColumnType("SMALLINT(2)");

                    b.Property<short>("UnitsOnOrder")
                        .HasColumnType("SMALLINT(2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Products");
                });

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

            modelBuilder.Entity("Northwind.EFCore.Models.Shipper", b =>
                {
                    b.Property<int>("ShipperID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT(11)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(24)");

                    b.HasKey("ShipperID");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT(11)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("ContactName")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Fax")
                        .HasColumnType("VARCHAR(24)");

                    b.Property<string>("HomePage")
                        .HasColumnType("MEDIUMTEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Territory", b =>
                {
                    b.Property<string>("TerritoryID")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<int>("RegionID")
                        .HasColumnType("INT(11)");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("TerritoryID");

                    b.HasIndex("RegionID");

                    b.HasIndex("TerritoryDescription")
                        .IsUnique();

                    b.HasIndex("TerritoryID")
                        .IsUnique();

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Employee", b =>
                {
                    b.HasOne("Northwind.EFCore.Models.Employee", "Manager")
                        .WithMany("Underlings")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("FK_Manager")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Order", b =>
                {
                    b.HasOne("Northwind.EFCore.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .HasConstraintName("FK_Customer")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Northwind.EFCore.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeID")
                        .HasConstraintName("FK_Employee")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Northwind.EFCore.Models.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia")
                        .HasConstraintName("FK_Shipper")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.OrderDetail", b =>
                {
                    b.HasOne("Northwind.EFCore.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .HasConstraintName("FK_Order")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Northwind.EFCore.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("FK_Product")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Product", b =>
                {
                    b.HasOne("Northwind.EFCore.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .HasConstraintName("FK_Category")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Northwind.EFCore.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .HasConstraintName("FK_Supplier")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Territory", b =>
                {
                    b.HasOne("Northwind.EFCore.Models.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionID")
                        .HasConstraintName("FK_Region")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Employee", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Underlings");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Region", b =>
                {
                    b.Navigation("Territories");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Northwind.EFCore.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
