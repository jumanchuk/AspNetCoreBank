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

        public async Task<Movements[]> GetByProductId(int ProductId)
        {
            return await _context.Movements.Where(x => x.Products.Id == ProductId).ToArrayAsync();
        }

        public void GetProductBalanceById(int Id)
        {
         var movements=(from m in _context.Movements
            select m)
            .Where(m => m.Products.Id == Id)
            .ToList();

            decimal currentBalance=movements.Sum(m => m.amount);

            var query = (from prod in _context.Products
            select prod)
            .Where(m => m.Id == Id)
            .ToList();

            foreach(Products prod in query)
            {
                prod.current_balance = currentBalance;
            }

            _context.SaveChanges();
        }

    }
}

