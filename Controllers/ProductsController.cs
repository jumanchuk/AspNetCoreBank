using System;
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
        
        public async Task<IActionResult> Index(int ClientId, int Id)
        {
          
        // Get Products from database
        var Products = await _ProductsService.GetProductsByClientId(ClientId);
        var productDetail = await _ProductsService.GetProductDetailById(Id);
        var productMovements = await _ProductsService.GetProductMovementsById(Id);

        // Put Products into a model
          var model = new ProductsViewModel()
          {
              Products = Products,
              ProductDetail = productDetail,
              ProductMovements = productMovements
          };
        // Render view using the model
        return View(model);
                
        }
  }
  
}