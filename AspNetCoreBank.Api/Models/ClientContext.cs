using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBank.Api.Models
{
        public class ClientContext: DbContext
    {
            
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }

    }
}
