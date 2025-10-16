using Microsoft.AspNetCore.Mvc;
using ASP1.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP1.Controllers
{
    public class ProductsController : Controller
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "Powerful laptop", Price = 3500 },
            new Product { Id = 2, Name = "Headphones", Description = "Noise-cancelling", Price = 800 },
            new Product { Id = 3, Name = "Smartphone", Description = "Latest model", Price = 2500 }
        };
        public IActionResult Index()
        {
            return View(_products);
        }
        public IActionResult Details(int id)
        {
            var product = new Product { Id = id, Name = "Laptop", Description = "Portable computer", Price = 2500 };
            return View(product);
        }
    }
}
