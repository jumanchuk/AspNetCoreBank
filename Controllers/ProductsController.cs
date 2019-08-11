using System.Threading.Tasks;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBank.Controllers
{
  public class ProductsController : Controller
  {
  private readonly IProductsService _ProductsService;
      
      public ProductsController(IProductsService ProductsService) => _ProductsService = ProductsService;
        
        public async Task<IActionResult> Index(int Document)
        {
          
        // Get Products from database
        var Products = await _ProductsService.GetProducts(Document);
        
        // Put Products into a model
          var model = new ProductsViewModel()
          {
              Products = Products
          };
        // Render view using the model
        return View(model);
        
        }
  }
}