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
    public class ProductsService : IProductsService
    {
        private readonly ApplicationDbContext _context;
        public ProductsService(ApplicationDbContext context)
        {
        _context = context;
        }
        public async Task<Products[]> GetProducts(int Document)
        {
            return await _context.Products
            .Where(x => x.Document == 95699120) // Como pasar parametro desde otra vista
            .ToArrayAsync();
        }
    }
}

