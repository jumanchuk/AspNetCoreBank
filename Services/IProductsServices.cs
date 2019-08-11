using System.Threading.Tasks;
using AspNetCoreBank.Models;

namespace AspNetCoreBank.Services
{
    public interface IProductsService
    {
        Task<Products[]> GetProducts(int Document);

    }
}