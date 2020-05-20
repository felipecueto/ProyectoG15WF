using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        string username;
        string password;
        string name;
        string mail;


        public User()
        {

        }

        public User(string username, string name, string email, string password)
            : this()

        {
            this.Username = username;
            this.Name = name;
            this.Password = password;
            this.Mail = email;
        }

        public string Name { get => name; set => name = value; }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }

        public bool CheckCredentials(string username, string pass)
        {
            if (this.Username.Equals(username) && this.Password.Equals(pass))
                return true;
            return false;
        }

    }
}