using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int UserId;  // BONUS MISSION-1 Add userId property to user object

        private static int nextId = 1;
       
        public DateTime UserDate = DateTime.Now;  // BONUS MISSION- 4 ADD USER CREATION TIME
        public User()
        {
            UserId = nextId;
            nextId++;
        }
    }

}
