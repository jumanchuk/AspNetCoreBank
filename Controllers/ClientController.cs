using System.Threading.Tasks;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBank.Controllers
{
  public class ClientController : Controller
  {
        private readonly IClientService _clientRowService;
        public ClientController(IClientService clientRowService) => _clientRowService = clientRowService;
        public async Task<IActionResult> Index()
        {
        // Get clients from database
        var clients = await _clientRowService.GetClientRows();
        
        // Put clients into a model
        var model = new ClientViewModel()
        {
            Clients = clients
        };
        // Render view using the model
        return View(model);
        } 
  }
}