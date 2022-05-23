using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.Model
{
    public class UserLoginModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public UserLoginModel(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public UserLoginModel()
        {
            UserName = string.Empty;
            Password = string.Empty;
        }
    }
}