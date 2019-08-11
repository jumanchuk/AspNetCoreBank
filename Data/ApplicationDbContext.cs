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
protected override void OnModelCreating(ModelBuilder builder)
{
        builder.Entity<Client>().HasData(
                new Client {
                    Id = Guid.NewGuid(),
                    Document = 95699120,
                    Name = "Jury",
                    Lastname = "Umanchuk",
                    Date = DateTime.Now},
                new Client {
                    Id = Guid.NewGuid(),
                    Document = 95885263,
                    Name = "Linda",
                    Lastname = "Perez",
                    Date = DateTime.Now}
                    );

        builder.Entity<ProductType>().HasData(
                new ProductType {
                    Id = Guid.NewGuid(),
                    Product_type = 1,
                    name = "Cuenta Ahorro",
                    status = 1},
                new ProductType {
                    Id = Guid.NewGuid(),
                    Product_type = 1,
                    name = "Cuenta Corriente",
                    status = 2},
                new ProductType {
                    Id = Guid.NewGuid(),
                    Product_type = 2,
                    name = "Prestamo Personal",
                    status = 3}
                    );

        builder.Entity<Products>().HasData(
                new Products {
                    Id = Guid.NewGuid(),
                    Document = 95699120,
                    Product_id = 7534563210,
                    Product_type = 1,
                    current_balance = 0,
                    status = 1,
                    Opening_date = DateTime.Now,
                    Closing_date = null},
                new Products {
                    Id = Guid.NewGuid(),
                    Document = 95699120,
                    Product_id = 7547854268,
                    Product_type = 2,
                    current_balance = 0,
                    status = 1,
                    Opening_date = DateTime.Now,
                    Closing_date = null}
                    );

        base.OnModelCreating(builder);
}
}

}