using Microsoft.AspNetCore.Mvc;
using RazorBasics.Models;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RazorBasics.Views {

    public class ClientController : Controller {

        // GET: /<controller>/
        public IActionResult NewClient() {
            var newClient = new Client();
            newClient.EmailPromos = new List<EmailPromo>()
            {
                new EmailPromo() { Id = 1, Title = "Weekly Deal", IsSubscribed = false },
                new EmailPromo() { Id = 2, Title = "Holiday Promos", IsSubscribed = false },
                new EmailPromo() { Id = 3, Title = "Company Newsletter", IsSubscribed = false },
                new EmailPromo() { Id = 4, Title = "New Products", IsSubscribed = false }
            };

            return View(newClient);
            //return View();
        }

        [HttpPost]
        public IActionResult NewClient(Client newClient) {
            if (ModelState.IsValid) {
                return RedirectToAction("Index", "Home");
            } else {
                return View(newClient);
            }
        }

        public IActionResult VerifyEmail(string email) {
            var emailList = new List<string>()
            {
                "test@example.com",
                "hello@example.com",
                "world@example.com"
            };

            if (emailList.Contains(email)) {
                return Json("Email is already taken");
            }

            return Json(true);
        }
    }
}