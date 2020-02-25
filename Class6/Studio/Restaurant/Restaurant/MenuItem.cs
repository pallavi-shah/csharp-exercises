using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
         public string ItemName { get; set; }
         public double Price { get; set; }
         public string Description { get; set; }
         public enum category { appetizer, maincourse, dessert };
         public DateTime AddedOn;
         public bool IsNew
         {
         get
            {
                return AddedOn.Date >= DateTime.Now.Date.AddMonths(-3);
            }
           
         }
         public MenuItem(string aItemName, double aPrice, string aDescription)
            {
                ItemName = aItemName;
                Price = aPrice;
                Description = aDescription;
            }

        //Method to display if the item is New;
        public string NewItem()
        {
            if (this.IsNew == true)
            {
                return "(New)";
            }
            else
                return "";
        }
        public void DisplayMenuItem()
        {
            Console.WriteLine("Menu Item : ");
            string result= "\n"+ ItemName + "\t" + Price + "\n" + Description;
            Console.WriteLine(result);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is MenuItem))
            {
                return false;
            }

            else
                return this.ItemName == ((MenuItem)obj).ItemName && this.Price == ((MenuItem)obj).Price && this.Description == ((MenuItem)obj).Description;
        }

        public override int GetHashCode()
        {
            return this.ItemName.GetHashCode()^ this.Price.GetHashCode()^this.Description.GetHashCode();
        }


    }
}
