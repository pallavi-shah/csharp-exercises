using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name;
        public string Description;

        public Cheese(string aname, string adescription)
        {
            this.Name = aname;
            this.Description = adescription;
        }
    }
}
