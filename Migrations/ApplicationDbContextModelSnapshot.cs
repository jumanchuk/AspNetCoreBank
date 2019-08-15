﻿// <auto-generated />
using System;
using AspNetCoreBank.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreBank.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("AspNetCoreBank.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("Document");

                    b.Property<string>("Lastname")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new { Id = 1, Date = new DateTime(2019, 8, 11, 20, 56, 13, 951, DateTimeKind.Local), Document = 95699120, Lastname = "Umanchuk", Name = "Jury" },
                        new { Id = 2, Date = new DateTime(2019, 8, 11, 20, 56, 13, 957, DateTimeKind.Local), Document = 95885263, Lastname = "Perez", Name = "Linda" }
                    );
                });

            modelBuilder.Entity("AspNetCoreBank.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientId");

                    b.Property<DateTime?>("Closing_date");

                    b.Property<DateTime>("Opening_date");

                    b.Property<int?>("ProductTypeId");

                    b.Property<decimal>("current_balance");

                    b.Property<decimal>("status");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, ClientId = 1, Opening_date = new DateTime(2019, 8, 11, 20, 56, 13, 958, DateTimeKind.Local), ProductTypeId = 1, current_balance = 0m, status = 1m },
                        new { Id = 2, ClientId = 1, Opening_date = new DateTime(2019, 8, 11, 20, 56, 13, 959, DateTimeKind.Local), ProductTypeId = 2, current_balance = 0m, status = 1m }
                    );
                });

            modelBuilder.Entity("AspNetCoreBank.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Product_type");

                    b.Property<string>("name");

                    b.Property<int>("status");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new { Id = 1, Product_type = 1, name = "Cuenta Ahorro", status = 1 },
                        new { Id = 2, Product_type = 1, name = "Cuenta Corriente", status = 2 },
                        new { Id = 3, Product_type = 2, name = "Prestamo Personal", status = 3 }
                    );
                });

            modelBuilder.Entity("AspNetCoreBank.Models.Products", b =>
                {
                    b.HasOne("AspNetCoreBank.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("AspNetCoreBank.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
