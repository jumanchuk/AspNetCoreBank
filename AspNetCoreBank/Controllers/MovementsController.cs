using System;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBank.Controllers
{
    public class MovementsController: Controller
    {
        private readonly IClientService _clientService;
        private readonly IProductsService _productsService;
        private readonly IProductTypeService _productTypeService;
        private readonly IMovementService _movementService;
        private readonly IMovementTypeService _movementTypeService;

        public MovementsController(IClientService clientService, IProductsService productsService, IProductTypeService productTypeService, IMovementService movementService, IMovementTypeService movementTypeService)
        {
            _clientService = clientService;
            _productsService = productsService;
            _productTypeService = productTypeService;
            _movementService = movementService;
            _movementTypeService = movementTypeService;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Deposit(int ProductId)
        {
            var model = new MovementViewModel
            {
                ProductId = ProductId,
                ProductTypes = await _productTypeService.GetAll()
            };

          return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Deposit(MovementViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index", "Client");
            var product = await _productsService.GetProductDetailById(model.Products.Id);
            if (product == null)
                return RedirectToAction("Index");
            else
            {
                var movement = new Movements
                {
                    amount = model.amount,
                    date = DateTime.Now,
                    Products = await _productsService.GetProductDetailById(model.Products.Id),
                    MovementsType = await _movementTypeService.GetByType(1),
                    status = 1
                };
                
                var successful = await _movementService.AddAsync(movement);

                if (!successful)
                {
                    return BadRequest("No se pudo efectuar el deposito.");
                }
                    _productsService.UpdateProductBalanceById(model.Products.Id,model.amount);
                    return RedirectToAction("Index", "Products", new { ClientId = product.Client.Id, product.Id });

                }

        }

        public async Task<IActionResult> WithDraw(MovementViewModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index", "Client");
            var product = await _productsService.GetProductDetailById(model.Products.Id);
            if (product == null)
                return RedirectToAction("Index");
            else
            {
                var movement = new Movements
                {
                    amount = -model.amount,
                    date = DateTime.Now,
                    Products = await _productsService.GetProductDetailById(model.Products.Id),
                    MovementsType = await _movementTypeService.GetByType(2),
                    status = 1
                };
                
                var successful = await _movementService.AddAsync(movement);

                if (!successful)
                {
                    return BadRequest("No se pudo efectuar la Extracción.");
                }
                    _productsService.UpdateProductBalanceById(model.Products.Id,-model.amount);

                    return RedirectToAction("Index", "Products", new { ClientId = product.Client.Id, product.Id });

                }

        }
    }
}