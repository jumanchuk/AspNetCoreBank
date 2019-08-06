using System.Threading.Tasks;
using AspNetCoreBank.Models;

namespace AspNetCoreBank.Services
{
    public interface IClientService
    {
        Task<ClientRow[]> GetClientRows();
    }
}