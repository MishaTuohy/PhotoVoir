﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhotoVoir.Domain.DataAccess;

namespace PhotoVoir.Presentation.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211119201920_IntialDBCreation")]
    partial class IntialDBCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Orders.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrderHistory");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Orders.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("OrderItemPrice")
                        .HasColumnType("float");

                    b.Property<int>("OrderItemQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Orders.OrderStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OrderStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderStatusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PhotographerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<string>("ProductSize")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PhotographerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Products.ProductInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductIdId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderItemId");

                    b.HasIndex("ProductIdId");

                    b.ToTable("ProductInfo");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Users.Customer.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShippingAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShippingAddressId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Users.Photographer.Photographer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShippingAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShippingAddressId");

                    b.ToTable("Photographer");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Users.ShippingAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town_City")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShippingAddress");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Orders.Order", b =>
                {
                    b.HasOne("PhotoVoir.Domain.Entities.Users.Customer.Customer", null)
                        .WithMany("OrderHistory")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Orders.OrderItem", b =>
                {
                    b.HasOne("PhotoVoir.Domain.Entities.Orders.Order", null)
                        .WithOne("OrderItems")
                        .HasForeignKey("PhotoVoir.Domain.Entities.Orders.OrderItem", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("PhotoVoir.Domain.Entities.Users.Photographer.Photographer", null)
                        .WithMany("Products")
                        .HasForeignKey("PhotographerId");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Products.ProductInfo", b =>
                {
                    b.HasOne("PhotoVoir.Domain.Entities.Orders.OrderItem", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderItemId");

                    b.HasOne("PhotoVoir.Domain.Entities.Products.Product", "ProductId")
                        .WithMany()
                        .HasForeignKey("ProductIdId");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Users.Customer.Customer", b =>
                {
                    b.HasOne("PhotoVoir.Domain.Entities.Users.ShippingAddress", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressId");
                });

            modelBuilder.Entity("PhotoVoir.Domain.Entities.Users.Photographer.Photographer", b =>
                {
                    b.HasOne("PhotoVoir.Domain.Entities.Users.ShippingAddress", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
