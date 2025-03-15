using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Entities
{
    public abstract class User
    {
        public int Id { get; set; } // מפתח ראשי
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // hash של הסיסמה
                              // public string Role { get; set; }
        public User() { }
        public User(int id, string userName, string email, string password)
        {
            Id = id;
            UserName = userName;
            Email = email;
            Password = password;
        }

    }
}
