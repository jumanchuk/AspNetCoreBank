using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBank.Data;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBank.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _context;
        public ClientService(ApplicationDbContext context)
        {
        _context = context;
        }
        public async Task<ClientRow[]> GetClientRows(int Document)
        {
        return await _context.Clients
        .Where(x => x.Document == Document)
        .ToArrayAsync();
        }
    }
}