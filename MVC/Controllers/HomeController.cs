using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("b/{*x}/")]
        public IActionResult Index()
        {
            var javascript = "document.getElementById(\"demo\").innerHTML = \"Hello JavaScript!\"";
            return View("CreatedView1");
        }

        public IActionResult Privacy()
        {
            return ViewComponent("s");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Action();
            return View(new ErrorViewModel 
                { RequestId = Activity.Current?.Id ?? 
                              HttpContext.TraceIdentifier });
        }
    }
}
