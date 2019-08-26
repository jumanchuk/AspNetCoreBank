using System.Threading.Tasks;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBank.Controllers
{
  public class ClientController : Controller
  {
      private readonly IClientService _ClientService;

      public ClientController(IClientService ClientService) => _ClientService = ClientService;
        
        [Authorize]
        public async Task<IActionResult> Index(int Document)
        {
          
            // Get clients from database
            var client = await _ClientService.GetClient(Document);
            // Put clients into a model
            var model = new ClientsViewModel
            {
                Clients = (client != null) ? new Client[] { client } : null
            };
            // Render view using the model
            return View(model);
        }
  }
}