using System;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBank.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService _ProductsService;
        private readonly IProductTypeService _productTypeService;
        public ProductsController(IProductsService ProductsService, IProductTypeService productTypeService)
        {
            _ProductsService = ProductsService;
            _productTypeService = productTypeService;
        }
        
        public async Task<IActionResult> Index(int ClientId, int Id)
        {
            if (ClientId == 0)
                return Redirect("Client");
            // Get Products from database
            var Products = await _ProductsService.GetProductsByClientId(ClientId);
            if (Id == 0)
                Id = Products.ToList().FirstOrDefault().Id;
            var productDetail = await _ProductsService.GetProductDetailById(Id);
            var productMovements = await _ProductsService.GetByProductId(Id);
            var productTypes = await _productTypeService.GetAll();

            // Put Products into a model
            var model = new ProductsViewModel()
            {
                Products = Products,
                ProductDetail = productDetail,
                ProductMovements = productMovements,
                ProductTypes = productTypes
            };
            // Render view using the model
            return View(model);
        }
  }
  
}