using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{

    public class CheeseController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Cheese> cheeses = CheeseData.GetAll();
            return View(cheeses);
        }

        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();
            return View(addCheeseViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            if (ModelState.IsValid)
            {

                Cheese newCheese = addCheeseViewModel.CreateCheese();
                CheeseData.Add(newCheese);
                return Redirect("/Cheese");
            }

            return View(addCheeseViewModel  );
            
        }

    // Edit Action method to display the form
        public IActionResult Edit(int cheeseId)
        {
           Cheese cheese  = CheeseData.GetbyID(cheeseId);
            AddEditCheeseViewModel vm = new AddEditCheeseViewModel {
                CheeseID= cheese.CheeseID,
                Name = cheese.Name,
                Description=cheese.Description,  
                Rating=cheese.Rating
            };
            return View(vm);
        }

        // Edit Action method to process the form

        [HttpPost]
        public IActionResult Edit(AddEditCheeseViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Cheese cheese = CheeseData.GetbyID(vm.CheeseID);
                cheese.Name = vm.Name;
                cheese.Description = vm.Description;
                cheese.Rating = vm.Rating;
                return Redirect("/Cheese/Index");
            }
            else
            {
                return View(vm);
            }
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
    }
}
    