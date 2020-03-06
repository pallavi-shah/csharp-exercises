using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using CheeseMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{

    public class CheeseController : Controller
    {
        //Approach 1- using dictionary
        static private Dictionary<string,string> Cheeses = new Dictionary<string,string>();

        //Approach 2- using List of Cheese Objects
        static private List<Cheese> listCheeses = new List<Cheese>();
        

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;
            ViewBag.listcheeses = listCheeses;
            return View();

        }


        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Remove()

        {
            ViewBag.cheeses = Cheeses;  //Approach 1
            ViewBag.listcheeses = listCheeses;  //Approach 2
            return View();
        }
        [HttpPost]
        public IActionResult RemoveButton(string[] removeCheese)
        {
            for (int i = 0; i < removeCheese.Length; i++)   
            {
                Cheeses.Remove(removeCheese[i]); //approach 1
               // listCheeses.RemoveAt(i); // approach 2      TODO NEED TO FIX
            }


            ViewBag.cheeses = Cheeses;  //Approach 1
            //ViewBag.listcheeses =listCheeses; // Approach 2;
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
                //Approach 1- using dictionary
                Cheeses.Add(name, description);

                //Approach 2- Using List of cheese object
                 Cheese c1 = new Cheese(name, description);
                listCheeses.Add(c1);  //
                

                return Redirect("/Cheese");
              }
        }
    }
}
    