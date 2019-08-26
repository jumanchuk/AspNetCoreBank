using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBank.Data;
using AspNetCoreBank.Models;

namespace AspNetCoreBank.Services
{
    public class MovementService : IMovementService
    {
        private readonly ApplicationDbContext _context;
        public MovementService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddAsync(Movements movement)
        {
            movement.date = DateTime.Now;            

            _context.Movements.Add(movement);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}
