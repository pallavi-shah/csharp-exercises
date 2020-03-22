using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CheeseID;
        private static int nextID=1;
        public int Rating { get; set; }

        
        public Cheese()
        {
            CheeseID = nextID;
            nextID++;
        }
    }
}
