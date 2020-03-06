using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs.Controllers
{
    // BONUS MISSION- TechJobsController base class for specifying columnChoices and actions to be used by view.
    public class TechJobsController : Controller
    {
        public static Dictionary<string, string> actionChoices = new Dictionary<string, string>();

        internal static Dictionary<string, string> columnChoices = new Dictionary<string, string>();
        static TechJobsController()
        {
            columnChoices.Add("core competency", "Skill");
            columnChoices.Add("employer", "Employer");
            columnChoices.Add("location", "Location");
            columnChoices.Add("position type", "Position Type");
            columnChoices.Add("all", "All");
            actionChoices.Add("list", "List");
            actionChoices.Add("search", "Search");
        }

        public override ViewResult View()
        {
            ViewBag.columns = columnChoices;
            ViewBag.actions = actionChoices;
            return base.View();
        }
        public override ViewResult View(string viewName)
        {
            ViewBag.columns = columnChoices;
            ViewBag.actions = actionChoices;
            return base.View(viewName);
        }
    }
}

