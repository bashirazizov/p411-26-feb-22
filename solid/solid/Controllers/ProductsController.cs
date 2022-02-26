using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using solid.DAL;
using solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext db;

        public ProductsController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult AddToBasket(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Product productToAddToBasket = db.Products.FirstOrDefault(x => x.Id == id);

            if (productToAddToBasket == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Product> basket = new List<Product>();
            basket.Add(productToAddToBasket);

            string basketAsString = JsonConvert.SerializeObject(basket);

            Response.Cookies.Append("basket", basketAsString);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult GetBasket()
        {
            return Content(Request.Cookies["basket"]);
        }

    }
}
