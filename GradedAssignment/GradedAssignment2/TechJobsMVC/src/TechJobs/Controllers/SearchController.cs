using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : TechJobsController
    {
        
        public IActionResult Index()
        {
            //ViewBag.columns = ListController.columnChoices;  //Commented as added to TechJobsController-base class methods for BONUS MISSION 
            ViewBag.title = "Search";
            ViewBag.search_type = "all";  // searchType = "all" passed into ViewBag to make it default when the page loads.
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        
        public IActionResult Results(string searchType, string searchTerm)
        {
            
            if (searchType != "all")
            {
                List<Dictionary<string, string>> jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
                ViewBag.jobs = jobs;
                //ViewBag.columns = ListController.columnChoices;
                ViewBag.title = "Search";
                ViewBag.search_type = searchType;
            }
            else
            {
                List<Dictionary<string, string>> jobs = JobData.FindByValue(searchTerm);
                ViewBag.jobs = jobs;
                //ViewBag.columns = ListController.columnChoices;
                ViewBag.title = "Search";
                ViewBag.search_type = searchType;
            }
            return View("Index");

        }

    }
}
