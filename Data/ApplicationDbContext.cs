using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreBank.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBank.Data
{
        public class ApplicationDbContext: DbContext
    {
            
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Movements> Movements { get; set; }
        public DbSet<Movements> MovementsType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
                builder.Entity<Client>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();
                
                builder.Entity<Client>()
                .HasData(
                    new Client {
                        Id = 1,
                        Document = 95699120,
                        Name = "Jury",
                        Lastname = "Umanchuk",
                        Date = DateTime.Now},
                    new Client {
                        Id = 2,
                        Document = 95885263,
                        Name = "Linda",
                        Lastname = "Perez",
                        Date = DateTime.Now}
                        );

                builder.Entity<ProductType>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

                builder.Entity<ProductType>()
                .HasData(
                    new ProductType {
                        Id = 1,
                        Product_type = 1,
                        name = "Cuenta Ahorro",
                        status = 1},
                    new ProductType {
                        Id = 2,
                        Product_type = 1,
                        name = "Cuenta Corriente",
                        status = 2},
                    new ProductType {
                        Id = 3,
                        Product_type = 2,
                        name = "Prestamo Personal",
                        status = 3
                        });

                builder.Entity<Products>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

                builder.Entity<Products>()
                .HasData(
                    new {
                        Id = 1,
                        current_balance = (decimal)150,
                        status = 1,
                        Opening_date = DateTime.Now,
                        ProductTypeId = 1,
                        ClientId = 1
                    },
                    new {
                        Id = 2,
                        current_balance = (decimal)100,
                        status = 1,
                        Opening_date = DateTime.Now,
                        ProductTypeId = 2,
                        ClientId = 1
                        });

                builder.Entity<MovementsType>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

                builder.Entity<MovementsType>()
                .HasData(
                    new {
                        Id = 1,
                        Movements_type=1,
                        status = 1,
                        name="Deposito"
                    },
                    new {
                        Id = 2,
                        Movements_type=2,
                        status = 1,
                        name="Transferencia"
                        });

                builder.Entity<Movements>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

                builder.Entity<Movements>()
                .HasData(
                    new {
                        Id = 1,
                        ProductId=1,
                        MovementsTypeId = 1,
                        amount = (decimal)150,
                        status = 1,
                        date = DateTime.Now,
                    },
                    new {
                        Id = 2,
                        ProductId=1,
                        MovementsTypeId = 2,
                        amount = (decimal)100,
                        status = 1,
                        date = DateTime.Now,
                        });

                base.OnModelCreating(builder);
        }
    }
}
