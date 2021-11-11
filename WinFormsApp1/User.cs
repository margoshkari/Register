using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public User()
        {
            Login = "";
            Password = "";
        }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
