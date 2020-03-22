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

        public DateTime UserDate = DateTime.Now;
        public string Password { get; set; }

        
        public string SecretQuestion {get; set; }

    public string SecretAnswer { get; set; }

        public int UserId;
        
        private static int nextId = 1;

        public User()
        {
            UserId = nextId;
            nextId++;
        }
    }
}
