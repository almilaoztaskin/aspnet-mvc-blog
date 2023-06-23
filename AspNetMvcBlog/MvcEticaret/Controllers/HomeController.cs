using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;
using MvcEticaret.ViewComponents;

namespace MvcEticaret.Controllers
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
            var productList = new List<ProductItemViewModel>
            {
                new ProductItemViewModel
                {
                    Title= "Product 1",
                    StarCount = 2,
                    OldPrice = 50,
                    Price = 75,
                    ImageUrl = "/images/pencil1.jpg",
                    IsSale = false,
                },
                new ProductItemViewModel
                {
                    Title= "Product 2",
                    StarCount = 3,
                    OldPrice = 75,
                    Price = 95,
                    ImageUrl = "/images/pencil2.jpg",
                    IsSale = false,
                },
                new ProductItemViewModel
                {
                    Title= "Product 3",
                    StarCount = 4,
                    OldPrice = 100,
                    Price = 125,
                    ImageUrl = "/images/pencil3.jpg",
                    IsSale = true,
                },
                new ProductItemViewModel
                {
                    Title= "Product 4",
                    StarCount = 5,
                    OldPrice = 95,
                    Price = 80,
                    ImageUrl = "/images/pencil4.jpg",
                    IsSale = true,
                },
                new ProductItemViewModel
                {
                    Title= "Product 5",
                    StarCount = 0,
                    OldPrice = 35,
                    Price = 75,
                    ImageUrl = "/images/pencil5.jpg",
                    IsSale = false,
                },
                new ProductItemViewModel
                {
                    Title= "Product 6",
                    StarCount = 5,
                    OldPrice = 95,
                    Price = 97,
                    ImageUrl = "/images/pencil6.jpg",
                    IsSale = true,
                },
                new ProductItemViewModel
                {
                    Title= "Product 7",
                    StarCount = 5,
                    OldPrice = 100,
                    Price = 75,
                    ImageUrl = "/images/pencil7.jpg",
                    IsSale = true,
                },
                new ProductItemViewModel
                {
                    Title= "Product 8",
                    StarCount = 5,
                    OldPrice = 95,
                    Price = 75,
                    ImageUrl = "/images/pencil8.jpg",
                    IsSale = false,
                },
            };
            return View(productList);
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