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
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.listcheeses = CheeseData.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Remove()
        {
            ViewBag.listcheeses = CheeseData.GetAll();
            return View();
        }


        [HttpPost]
        public IActionResult RemoveButton(int[] removeCheese)
        {
            for (int i = 0; i < removeCheese.Length; i++)
            {
                foreach (int cheeseID in removeCheese)
                {
                    CheeseData.Remove(cheeseID);
                }

            }
            ViewBag.listcheeses = CheeseData.GetAll();
            return View("Index");
        }


        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(Cheese newCheese)
        {
            CheeseData.Add(newCheese);  //
            return Redirect("/Cheese");
        }

        //Action method to display the form
        public IActionResult Edit(int cheeseId)
        {
            ViewBag.cheese = CheeseData.GetbyID(cheeseId);
            return View();
        }

        //Action method to process the form

        [HttpPost]
        public IActionResult Edit(int cheeseId, string name, string description)
         {
            CheeseData.Update(cheeseId, name, description);
            return Redirect("/Cheese/Index");
         }

    }
}
    