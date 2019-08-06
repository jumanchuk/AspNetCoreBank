// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using AspNetCoreBank.Data;
// using AspNetCoreBank.Models;
// using Microsoft.EntityFrameworkCore;

// namespace AspNetCoreBank.Services
// {
//     public class ClientRowService: IClientService
//     {
//         private readonly ApplicationDbContext _context;

//         public ClientRowService(ApplicationDbContext context)
//         {
//             _context = context;
//         }

//         public async Task<ClientRow[]> GetClientRows()
//         {
//             return await _context.Items
//                 .ToArrayAsync();
//         }
//     }
// }
