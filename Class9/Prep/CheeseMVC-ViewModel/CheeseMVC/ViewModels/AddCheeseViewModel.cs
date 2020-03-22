using CheeseMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
     
        [Required]
        [Display (Name="Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter the Cheese description")]
        public string Description { get; set; }
        
        [Range(1,5,ErrorMessage ="Please enter Rating between 1-5")]
        public int Rating { get; set; }

        public Cheese CreateCheese()
        {
            Cheese newCheese = new Cheese
            {
                Name = this.Name,
                Description = this.Description,
                Rating = this.Rating
            };
            return newCheese ;
        }
            
    }
}
