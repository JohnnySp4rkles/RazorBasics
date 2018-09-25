using Microsoft.AspNetCore.Mvc;
using Razor_Basics.Models;
using RazorBasics.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Razor_Basics.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {
            // Collection we was to pass to the view
            var orders = new List<Order>() {
                new Order() {Name = "Johnny Diamond", Description="Porro recusabo nominati sea cu, an vix erant choro nusquam, apeirian detraxit tacimates et duo? In est mandamus inciderint. Cu mea justo facilis, id mucius blandit insolens pro.", LastUpdated=DateTime.Now.AddDays(-2)},
                new Order() {Name = "Iqrah Mckeown", Description="Et fabulas insolens scriptorem mei, his cu dicam commune! Pri quando nostro suscipiantur in.", LastUpdated=DateTime.Now.AddDays(-6)},
                new Order() {Name = "Zahara Carver", Description="Sea veri quodsi omittam et, eam ea solum feugiat? Sea simul sensibus efficiendi ad? Fabellas eloquentiam vis et, cu usu autem sapientem unum.", LastUpdated=DateTime.Now.AddDays(-27)},
                new Order() {Name = "Ava-Mai Ramos", Description="Ad cum mutat consectetuer. Utinam aliquam has id. Mel ut brute labitur, mel in falli ocurreret sadipscing! Cum ne agam prima regione, cu nihil ancillae per.", LastUpdated=DateTime.Now.AddDays(-12)},
                new Order() {Name = "Chester Thorpe", Description="Dico duis altera mei te, id mei illum semper prompta? Ne vis illud homero petentium, sea unum vocibus reformidans no. Impetus epicuri tincidunt pri.", LastUpdated=DateTime.Now.AddDays(-9)},
                new Order() {Name = "Lamar Macias", Description="Duo elit brute ei? Nec fabulas.", LastUpdated=DateTime.Now.AddDays(-30)},
            };

            // A view bag, dynamic collection you can add items to and access from the view.
            ViewBag.Orders = orders;

            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Vote(int id) {
            return ViewComponent("SurveyWidget", new { ProductId = id });
        }
    }
}