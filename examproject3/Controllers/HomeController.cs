using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using System.Diagnostics;
using examproject3.Models;
using static webshopContext;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = new List<Product>();
            var context = new webshopContext();
            var products = context.Product;
            foreach (var x in products)
            {
                list.Add(x);
            }
            ViewBag.Products = list ;
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}