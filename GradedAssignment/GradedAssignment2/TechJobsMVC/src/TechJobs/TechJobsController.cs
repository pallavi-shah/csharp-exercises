using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs
{
    public class TechJobsController : Controller
    {
        public static Dictionary<string, string> actionChoices = new Dictionary<string, string>();

        // GET: /<controller>/

        static TechJobsController()
        {
            actionChoices.Add("list", "List");
            actionChoices.Add("search", "Search");
        }

        public override ViewResult View()
        {
            ViewBag.actions = actionChoices;
            return base.View();
        }

        public override ViewResult View(string viewName)
        {
            ViewBag.actions = actionChoices;
            return base.View("viewName");
        }

        public IActionResult Index()
        {
           // return View();
        }
    }
}
