using System;
using System.Collections.Generic;
namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }

     public class Menu
     {
        public static List<MenuItem> MenuItems = new List<MenuItem>();
        private static DateTime lastUpdated;
     }
      public class MenuItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public enum category { appetizer, maincourse, dessert };
        private DateTime dateadded;
        public bool IsNew;

        public MenuItem(string aItemName, double aPrice, string aDescription)
        {
            ItemName = aItemName;
            Price = aPrice;
            Description = aDescription;
        }
    }
}
