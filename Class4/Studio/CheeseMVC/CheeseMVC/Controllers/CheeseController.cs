using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;
            return View();

        }


        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Remove()

        {
            ViewBag.cheeses = Cheeses;
            return View();
        }
        [HttpPost]
        public IActionResult RemoveButton(string[] removeCheese)
        {
            for (int i = 0; i < removeCheese.Length; i++)   
            {
                Cheeses.Remove(removeCheese[i]);
            }
            ViewBag.cheeses = Cheeses;
            return View("Index");
        }


        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            Regex rx = new Regex("[^a-zA-z ]");
            if (name == null)
            {
                ViewBag.error = "Error: Cheese Name is Required.";
                return View("Add");
            }else if (Cheeses.ContainsKey(name))
            {
                ViewBag.error = "Error: Cheese already exists.";
                return View("Add");
            }else if(rx.IsMatch(name) == true)
            {
                ViewBag.error = "Error: Invalid Cheese Name,No special characters or numbers allowed.";
                return View("Add");
            } else             
              {
                Cheeses.Add(name, description);
                return Redirect("/Cheese");
              }
        }
    }
}
    