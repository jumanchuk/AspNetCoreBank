using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreBank.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBank.Data
{
    public class ApplicationDbContext: DbContext //Que es
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
{
}
public DbSet<ClientRow> Clients { get; set; }
protected override void OnModelCreating(ModelBuilder builder)
{
        builder.Entity<ClientRow>().HasData(
                new ClientRow {
                    Id = Guid.NewGuid(),
                    Name = "Jury",
                    Lastname = "Umanchuk",
                    Date = DateTime.Now},
                new ClientRow {
                    Id = Guid.NewGuid(),
                    Name = "Linda",
                    Lastname = "Perez",
                    Date = DateTime.Now}
                    );

        base.OnModelCreating(builder);
// ...
}
}

}