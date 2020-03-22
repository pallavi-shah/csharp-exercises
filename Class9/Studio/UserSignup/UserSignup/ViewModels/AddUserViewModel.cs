using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.Models;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = " Passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Verify Password")]
        public string Verify { get; set; }

        public string SecretAnswer { get; set; }
        public string SecretQuestion { get; set; }

        public List<SelectListItem> SecretQuestions = new List<SelectListItem>();
        public AddUserViewModel()
        {
            SelectListItem s1 = new SelectListItem
            {
                Value =0.ToString(),
                Text = "What is your mother's Maiden Name ?"
            };

            SelectListItem s2 = new SelectListItem
            {
                Value = 1.ToString(),
                Text = "What is the name of your first school ?"
            };
            SelectListItem s3 = new SelectListItem
            {
                Value = 2.ToString(),
                Text="In which city were you born ?"            
            };

            SecretQuestions.Add(s1);
            SecretQuestions.Add(s2);
            SecretQuestions.Add(s3);


        }

        
        
        
    }
}
