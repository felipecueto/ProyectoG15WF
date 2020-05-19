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
        int age;
        List<User> users;
        public User()
        {
            users = new List<User>();
        }

        public User(string username, string name, string password)
            :this()

        {
            this.Username = username;
            this.Name = name;
            this.Password = password;
        }

        public string Name { get => name; set => name = value; }
        
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        
        public bool CheckCredentials(string username, string pass)
        {
            if (this.Username.Equals(username) && this.Password.Equals(pass))
                return true;
            return false;
        }
        
    }
}
