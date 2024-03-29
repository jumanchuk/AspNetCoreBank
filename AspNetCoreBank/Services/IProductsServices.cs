using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreBank.Models;

namespace AspNetCoreBank.Services
{
    public interface IProductsService
    {
        Task<Products[]> GetProductsByClientId(int ClientId);
        Task<Products> GetProductDetailById(int Id);
        Task<Movements[]> GetProductMovementsById(int Id);
        Task<Movements[]> GetByProductId(int ProductId);
        void UpdateProductBalanceById(int id, decimal amount);
    }
}