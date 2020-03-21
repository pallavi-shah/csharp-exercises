using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        public static List<User> listOfUsers = new List<User>();

        //GET
       public static List<User> GetAll()
        {
            return listOfUsers ;
        }
        
        //ADD
        public static void Add(User newUser)
        {
            listOfUsers.Add(newUser);
        }

        //GETBYID
        public static User GetById(int Id)
        {
            return listOfUsers.Single(x=>x.UserId== Id);
        }
    }
}
