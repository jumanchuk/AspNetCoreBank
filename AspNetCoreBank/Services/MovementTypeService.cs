using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBank.Data;
using AspNetCoreBank.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBank.Services
{
    public class MovementTypeService : IMovementTypeService
    {
        private readonly ApplicationDbContext _context;
        public MovementTypeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<MovementsType[]> GetAll()
        {
            return await _context.MovementsType.ToArrayAsync();
        }

        public async Task<MovementsType> GetByType(int movementType)
        {
            return await _context.MovementsType.FirstOrDefaultAsync(x => x.Movements_type == movementType);
        }
    }
}
