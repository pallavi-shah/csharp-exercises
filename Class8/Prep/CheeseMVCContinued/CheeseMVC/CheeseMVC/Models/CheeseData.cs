using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseData
    {
        static private List<Cheese> listCheeses = new List<Cheese>();

        //GetAll

        public static List<Cheese> GetAll()
        {
            return listCheeses;
        }

        //Add

        public static void Add(Cheese ch)
        {
            listCheeses.Add(ch);
        }

        //Remove

        public static void Remove(int id)
        {
            listCheeses.Remove(GetbyID(id));
        }
        //GetByID

        public static Cheese GetbyID(int id)
        {
            return listCheeses.Single(x => x.CheeseID == id);
        }

        public static void Update( int id, string name, string description)
        { 
            Cheese c = GetbyID(id);
            c.Name = name;
            c.Description = description;
        }
    }

}
