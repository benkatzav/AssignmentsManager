using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTasksManager.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        public override string ToString()
        {
            return "Username: " + Username;
        }
    }
}