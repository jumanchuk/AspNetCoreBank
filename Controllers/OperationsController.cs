using System.Threading.Tasks;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBank.Controllers
{
  public class OperationsController : Controller
  {
        public IActionResult Index()
        {
            return View();
        }
  }
}