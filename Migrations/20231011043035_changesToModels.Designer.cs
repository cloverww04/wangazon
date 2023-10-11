﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using wangazon;

#nullable disable

namespace wangazon.Migrations
{
    [DbContext(typeof(WangazonDbContext))]
    [Migration("20231011043035_changesToModels")]
    partial class changesToModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MenuItemOrder", b =>
                {
                    b.Property<int>("MenuItemsId")
                        .HasColumnType("integer");

                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.HasKey("MenuItemsId", "OrdersId");

                    b.HasIndex("OrdersId");

                    b.ToTable("OrderMenuItem", (string)null);
                });

            modelBuilder.Entity("OrderOrderType", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("OrdersId", "TypeId");

                    b.HasIndex("TypeId");

                    b.ToTable("OrderOrderTypes", (string)null);
                });

            modelBuilder.Entity("OrderPaymentType", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentTypesId")
                        .HasColumnType("integer");

                    b.HasKey("OrdersId", "PaymentTypesId");

                    b.HasIndex("PaymentTypesId");

                    b.ToTable("OrderPaymentType", (string)null);
                });

            modelBuilder.Entity("wangazon.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "N.clover@email.com",
                            FirstName = "Nathan",
                            LastName = "Clover"
                        });
                });

            modelBuilder.Entity("wangazon.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pepperoni pizza with extra cheese",
                            Name = "Pizza",
                            Price = 16.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Greasy, fried, and sizzling wangs",
                            Name = "Wangs",
                            Price = 12.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Oreo Milk-Shake with whip cream",
                            Name = "Milk-Shake",
                            Price = 7.99m
                        });
                });

            modelBuilder.Entity("wangazon.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("text");

                    b.Property<string>("CustomerFirstName")
                        .HasColumnType("text");

                    b.Property<string>("CustomerLastName")
                        .HasColumnType("text");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("text");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("OrderClosed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("OrderPlaced")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("RevenueId")
                        .HasColumnType("integer");

                    b.Property<string>("Review")
                        .HasColumnType("text");

                    b.Property<decimal>("Tip")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RevenueId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerEmail = "john.doe@example.com",
                            CustomerFirstName = "John",
                            CustomerLastName = "Doe",
                            CustomerPhone = "555-123-4567",
                            EmployeeId = 1,
                            OrderClosed = new DateTime(2023, 10, 10, 23, 0, 34, 973, DateTimeKind.Local).AddTicks(9846),
                            OrderPlaced = new DateTime(2023, 10, 10, 21, 30, 34, 973, DateTimeKind.Local).AddTicks(9843),
                            Review = "Great service!",
                            Tip = 2.00m
                        },
                        new
                        {
                            Id = 2,
                            CustomerEmail = "bob.dole@example.com",
                            CustomerFirstName = "Bob",
                            CustomerLastName = "Dole",
                            CustomerPhone = "555-231-1267",
                            EmployeeId = 1,
                            OrderClosed = new DateTime(2023, 10, 10, 23, 0, 34, 973, DateTimeKind.Local).AddTicks(9851),
                            OrderPlaced = new DateTime(2023, 10, 10, 21, 30, 34, 973, DateTimeKind.Local).AddTicks(9850),
                            Review = "It was ok",
                            Tip = 5.00m
                        });
                });

            modelBuilder.Entity("wangazon.Models.OrderMenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MenuItemId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderMenuItems");
                });

            modelBuilder.Entity("wangazon.Models.OrderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrderTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Call In"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Walk In"
                        });
                });

            modelBuilder.Entity("wangazon.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Credit Card"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Cash"
                        });
                });

            modelBuilder.Entity("wangazon.Models.Revenue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Revenues");
                });

            modelBuilder.Entity("MenuItemOrder", b =>
                {
                    b.HasOne("wangazon.Models.MenuItem", null)
                        .WithMany()
                        .HasForeignKey("MenuItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wangazon.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderOrderType", b =>
                {
                    b.HasOne("wangazon.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wangazon.Models.OrderType", null)
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OrderPaymentType", b =>
                {
                    b.HasOne("wangazon.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wangazon.Models.PaymentType", null)
                        .WithMany()
                        .HasForeignKey("PaymentTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wangazon.Models.Order", b =>
                {
                    b.HasOne("wangazon.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wangazon.Models.Revenue", "Revenue")
                        .WithMany("Orders")
                        .HasForeignKey("RevenueId");

                    b.Navigation("Employee");

                    b.Navigation("Revenue");
                });

            modelBuilder.Entity("wangazon.Models.OrderMenuItem", b =>
                {
                    b.HasOne("wangazon.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wangazon.Models.Order", null)
                        .WithMany("OrderMenuItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("wangazon.Models.Revenue", b =>
                {
                    b.HasOne("wangazon.Models.Employee", "Employee")
                        .WithMany("Revenues")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("wangazon.Models.Employee", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Revenues");
                });

            modelBuilder.Entity("wangazon.Models.Order", b =>
                {
                    b.Navigation("OrderMenuItems");
                });

            modelBuilder.Entity("wangazon.Models.Revenue", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
