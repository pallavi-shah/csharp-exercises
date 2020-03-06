using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class    ListController : TechJobsController
    {
        // Commenting columnChoices code as it is included in TechJobsController-parent class BONUS MISSION
        //------------------------------------------------------------------------------------------------

       // internal static Dictionary<string, string> columnChoices = new Dictionary<string, string>();

        // This is a "static constructor" which can be used
        // to initialize static members of a class

        /*static ListController() ----------------->> Added to TechJobsController Class as part of Bonus Mission
        {
            olumnChoices.Add("core competency", "Skill");
            columnChoices.Add("employer", "Employer");
            columnChoices.Add("location", "Location");
            columnChoices.Add("position type", "Position Type");
            columnChoices.Add("all", "All");
        }*/


            //Returns list of all columnchoices.
        public IActionResult Index()
        {
            ViewBag.columns = columnChoices;
            return View();
        }

        //Returns values for a given column choice
        public IActionResult Values(string column)
        {
            if (column.Equals("all"))       // Returns all jobs if "All" columnchoice is selected from the list of Choices
            {
                List<Dictionary<string, string>> jobs = JobData.FindAll();
                ViewBag.title =  "All Jobs";
                ViewBag.jobs = jobs;
                return View("Jobs");
            }
            else
            {
                List<string> items = JobData.FindAll(column);       // Returns values for a given columnChoice
                ViewBag.title =  "All " + columnChoices[column] + " Values";
                ViewBag.column = column;
                ViewBag.items = items;
                return View();
            }
        }

        public IActionResult Jobs(string column, string value) //Returns all jobs for a given ColumnChoice and value
        {
            List<Dictionary<String, String>> jobs = JobData.FindByColumnAndValue(column, value);
            ViewBag.title = "Jobs with " + columnChoices[column] + ": " + value;
            ViewBag.jobs = jobs;
            return View();
        }
    }
}
