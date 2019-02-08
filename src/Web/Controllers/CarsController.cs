using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Greeting()
        {
            return Content("We have new cars!");
        }

        public IActionResult JSON()
        {
            return Json(new
            {
                name = "Kia",
                model = "Sorento"
            });
        }
  

        public IActionResult HTML()
        {
            return Content("<!DOCTYPE html><html><body>Hello User, we have nwe cars</body></html>", "text/html");
        }









    }
}