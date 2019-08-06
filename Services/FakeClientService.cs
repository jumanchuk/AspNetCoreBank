using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreBank.Models;
namespace AspNetCoreBank.Services
{
    public class FakeClientService : IClientService
    {
        public Task<ClientRow[]> GetClientRows()
        {
        var Client1 = new ClientRow
            {
            Name = "Jury",
            Lastname = "Umanchuk",
            Date = DateTime.Now
            };
        var Client2 = new ClientRow
            {
            Name = "Linda",
            Lastname = "Perez",
            Date = DateTime.Now
            };
        return Task.FromResult(new[] { Client1, Client2 });
        }
    }
}