using System;
using System.Collections.Generic;
namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem Item1 = new MenuItem("Cheese Pizza", 15, "Thin crust pizza topped with marinara sauce & Mozarella Cheese");
            MenuItem Item2= new MenuItem("Pasta", 15, "Ravioli pasta in Basil tomato sauce");
            MenuItem Item3 = new MenuItem("Salad", 8, "Lettuce,carrots,spinach,cheese,croutons salad with vinaigrette dressing");
            MenuItem Item4 = new MenuItem("Cheese Pizza", 15, "Thin crust pizza topped with marinara sauce & Mozarella Cheese");
            Menu m1 = new Menu();

            // method to Add MenuItem-Adding 4 Items
            Console.WriteLine("\n-------------------------------------------------------------------------");
            Console.WriteLine("1.Displaying Menu after adding 4 items and if a Menu Item is new");
            Console.WriteLine("-------------------------------------------------------------------------");
            m1.AddItem(Item1,DateTime.Now.Date);          
            m1.AddItem(Item2, DateTime.Today.AddMonths(-4));
            m1.AddItem(Item3,DateTime.Today.AddMonths(-2));
            m1.AddItem(Item4, DateTime.Today);
            Console.WriteLine(m1.ToString());

            // method to Remove MenuItem- Removing 1 item
            Console.WriteLine("\n-------------------------------------------------------------------------");
            Console.WriteLine("2.Displaying Menu after removing 1 item");
            Console.WriteLine("-------------------------------------------------------------------------");
            m1.RemoveItem(Item4,DateTime.Today.AddMonths(-1))   ;       
            Console.WriteLine(m1);

            //Method to Display a MenuItem'
            Console.WriteLine("\n-------------------------------------------------------------------------");
            Console.WriteLine("3.Displaying a Menu item");
            Console.WriteLine("-------------------------------------------------------------------------");
            Item1.DisplayMenuItem();
            Console.WriteLine("\n\n");

            //Method to determine whether or not two menu items are equal
            Console.WriteLine("\n-------------------------------------------------------------------------");
            Console.WriteLine("4.Displaying if 2 Menuitems are equal");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Is Item1 equal to Item4:  " + Item1.Equals(Item4));
            Console.WriteLine("Is Item1 equal to Item3:  " + Item1.Equals(Item3));
            Console.ReadLine();
        }

    }
 }
