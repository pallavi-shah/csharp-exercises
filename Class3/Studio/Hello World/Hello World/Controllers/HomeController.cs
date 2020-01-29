    using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hello_World.Models;

namespace Hello_World.Controllers
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
            return View();
        }

        public IActionResult Greet(string fname, string language)
        {
            string mesg = createMessage(fname, language);                 
                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public static string createMessage(string name, string language)
        {
            string shello = "hello";

            if (language=="french")
            {
                shello = "french hlell";
            }

            return shello + name;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CreateMessage()
        {
           return View();
        }
    }
}
