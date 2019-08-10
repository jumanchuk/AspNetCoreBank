using System.Threading.Tasks;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBank.Controllers
{
  public class ClientController : Controller
  {
      private readonly IClientService _ClientService;
      public ClientController(IClientService ClientService) => _ClientService = ClientService;
        
        public async Task<IActionResult> Index(int Document)
        {
          
        // Get clients from database
        var clients = await _ClientService.GetClientRows(Document);
        
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