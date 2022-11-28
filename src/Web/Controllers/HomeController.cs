using System.Diagnostics;
using HandTools.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HandTools.Infrastructure.Data;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                if (_context.Product != null)
                {
                    var products = await _context.Product.ToListAsync();
                    return View(products);
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
            }

            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        [HttpGet("/wishlist")]
        public IActionResult Wishlist()
        {
            return View();
        }

        [HttpGet("/cart")]
        public IActionResult Cart()
        {
            return View();
        }

        [HttpGet("/checkout")]
        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}