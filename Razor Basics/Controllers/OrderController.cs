using Microsoft.AspNetCore.Mvc;
using RazorBasics.Models;
using System.Collections.Generic;

namespace RazorBasics.Controllers {

    public class OrderController : Controller {

        public IActionResult NewOrder() {
            var newOrder = new Order();
            newOrder.Products = new List<OrderProductVM>() {
                new OrderProductVM(){Id=1, Name="Hoodie"},
                new OrderProductVM(){Id=2, Name="T-Shirt"},
                new OrderProductVM(){Id=3, Name="Banner"},
                new OrderProductVM(){Id=4, Name="Table Cloth"},
                new OrderProductVM(){Id=5, Name="Streamers"}
            };

            return View(newOrder);
        }

        [HttpPost]
        public IActionResult NewOrder(Order order) {
            return RedirectToAction("Index", "Home");
        }

    }
}