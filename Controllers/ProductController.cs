using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;
namespace ModelDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>()
            { 
                new Product { Id = 1,Name="Bag",Price=600},
                new Product { Id = 2,Name="pen",Price=78},
                new Product { Id = 3,Name="Pencil",Price=8},
                new Product { Id = 4,Name="Mouse",Price=299},
                new Product { Id = 5,Name="Pendrive",Price=399},
            };
            ViewBag.List = products;    
            return View();
        }
    }
}
