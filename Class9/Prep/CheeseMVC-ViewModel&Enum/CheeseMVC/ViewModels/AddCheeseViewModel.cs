using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        public AddCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>();
           
            SelectListItem s1 = new SelectListItem
            {
                Value = ((int)CheeseType.Hard).ToString(),
                Text = CheeseType.Hard.ToString()
            };

            SelectListItem s2 = new SelectListItem
            {
                Value = ((int)CheeseType.Soft).ToString(),
                Text = CheeseType.Soft.ToString()
            };
            SelectListItem s3 = new SelectListItem
            {
                Value = ((int)CheeseType.Fake).ToString(),
                Text = CheeseType.Fake.ToString()
            };

            CheeseTypes.Add(s1);
            CheeseTypes.Add(s2);
            CheeseTypes.Add(s3);

            /* CheeseTypes.Add(new SelectListItem  // OTHER METHOD OF ADDING ITEMS TO THE LIST
             {
                 Value = ((int)CheeseType.Hard).ToString(),
                 Text = CheeseType.Hard.ToString()
             });

             CheeseTypes.Add(new SelectListItem
             {
                 Value = ((int)CheeseType.Soft).ToString(),
                 Text = CheeseType.Soft.ToString()
             });

             CheeseTypes.Add(new SelectListItem
             {
                 Value = ((int)CheeseType.Fake).ToString(),
                 Text = CheeseType.Fake.ToString()
             });  
             */
        }

        public Cheese CreateCheese()
        {
            Cheese newCheese = new Cheese
            {
                Name = this.Name,
                Description = this.Description,
                Rating = this.Rating,
                Type=this.Type

            };
            return newCheese ;
        }
            
    }
}
