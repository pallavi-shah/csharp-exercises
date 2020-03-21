using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = UserData.GetAll();
           return View(users);
        }

        public IActionResult Add()
        {
            AddUserViewModel vm = new AddUserViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel vm)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = vm.Username,
                    Email= vm.Email,
                    Password= vm.Password,
                    SecretQuestion=vm.SecretQuestion,
                    SecretAnswer=vm.SecretAnswer
                };
                UserData.Add(newUser);
                return Redirect("/User/Index");
            }
            return View();
        }
            
        public IActionResult Details(int userId)
        {
            User user = UserData.GetById(userId);
            return View(user);
        }
    }
}