using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBank.Data;
using AspNetCoreBank.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBank.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly ApplicationDbContext _context;
        public ProductTypeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ProductType[]> GetAll()
        {
            return await _context.ProductTypes.ToArrayAsync();
        }
    }
}
