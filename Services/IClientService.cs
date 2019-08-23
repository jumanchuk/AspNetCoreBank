using System.Threading.Tasks;
using AspNetCoreBank.Models;

namespace AspNetCoreBank.Services
{
    public interface IClientService
    {
        Task<Client> GetClient(int Document);
        Task<Client> GetById(int Id);
    }
}