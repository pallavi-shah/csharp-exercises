using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }=new List<MenuItem>();
        public DateTime MenuLastUpdated;
        public bool NewItemsAvailable
        {
            get
            {
                bool result = false;
                foreach(MenuItem item in MenuItems)
                {
                    if (item.IsNew)
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }
        }

        // Method to Add Menu Item
        public void AddItem(MenuItem m, DateTime aAddedOn)
        {
            
            MenuItems.Add(m);
           m.AddedOn = aAddedOn;
            //m.AddedOn = DateTime.Today.AddMonths(-4);
           MenuLastUpdated =DateTime.Today;       
        }
        // Method to remove Menu Item
        public void RemoveItem(MenuItem m, DateTime abc)
        {
            MenuItems.Remove(m);
            MenuLastUpdated = DateTime.Today;
        }
        public override string ToString()
        {
            var result = "";
            Console.WriteLine("\t\t  Menu" + "\n\t\t ======\n");
            foreach (MenuItem item in MenuItems)
            {
               // if (!item.IsNew)
                //{
                    result += item.ItemName + item.NewItem() + "\t" + item.Price + "\n" + item.Description + "\n\n";
               
              // else
               //{
                 // result += item.ItemName + "\t" + item.Price + "\n" + item.Description +"\n\n";
                //}
            }
            result += "\t\t\t\t\t\tMenu Last updated On: "+ this.MenuLastUpdated.ToShortDateString();
            return result;
        }
    }
}
