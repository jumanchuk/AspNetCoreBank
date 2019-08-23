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
        public async Task<Products[]> GetProductsByClientId(int ClientId)
        {
            return await _context.Products
            .Where(x => x.Client.Id == ClientId)
            .ToArrayAsync();
        }

        public async Task<Products> GetProductDetailById(int Id)
        {
            return await _context.Products
            .FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<Movements[]> GetProductMovementsById(int Id)
        {
            return await _context.Movements
            .Where(x => x.Id == Id)
            .ToArrayAsync();
        }

        public async List<Movements> GetProductMovementsBalanceById(int Id)
        {

            return await _context.Movements
            .Where(x => x.Id == Id)
            .GroupBy(x => x.Id == Id)
            .ToArrayAsync();

        }

        public async Task<Movements[]> GetByProductId(int ProductId)
        {
            return await _context.Movements.Where(x => x.Products.Id == ProductId).ToArrayAsync();
        }
    }
}

