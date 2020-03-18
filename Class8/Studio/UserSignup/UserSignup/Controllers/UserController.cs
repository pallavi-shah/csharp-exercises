using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.userlist=UserData.GetAll();

            return View();
        }

       public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
       //[Route("/User/Add")]
        public IActionResult Add(User user, string verify)
        {
            // BONUS MISSION-2 INPUT VALIDATIONS

            if (user.Username == null)
            {
               // ViewBag.user_name = user.Username;
                ViewBag.user_email = user.Email;
                ViewBag.error = "Username cannot be blank.";

                return View();
            }
            else
            {
                Regex rx = new Regex("^[a-zA-Z]{5,15}$");
                if (rx.IsMatch(user.Username))
                {
                    ViewBag.user_name = user.Username;
                    ViewBag.user_email = user.Email;
                    //return View("Index");
                }
                else
                {
                    ViewBag.error = "Invalid Username.\n Username should be 5-15 alphabets only.";
                    //ViewBag.user_name = null;
                    ViewBag.user_email = user.Email;
                    return View();
                }
            }

            if (user.Email == null)
            {
                ViewBag.error = "Email cannot be blank.";
                return View();
            }
                       
            if(verify == user.Password)
            {
                //ViewBag.userObj = user;   
               // ViewBag.user_email = user.Email;
                UserData.Add(user);
                return Redirect("/User/Index");
            }
            else
            {
                ViewBag.user_name = user.Username;
                ViewBag.user_email = user.Email;
                ViewBag.error = "Passwords do not match. Please Try again !!";
                return View();
            }
        }

        // BONUS MISSION 3- DISPLAYING DETAILS OF USER
        public IActionResult Details(int userId)
        {
            ViewBag.user =UserData.GetById(userId);

            return View();

        }
    }
}