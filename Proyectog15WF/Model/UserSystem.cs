using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class UserSystem
    {
       
        private Dictionary<int, List<User>> registered;
        public UserSystem()
        {
            registered = new Dictionary<int, List<User>>();
        }
        public void Register(string name, string lastName, string usr, string email, string psswd)
        {
            User user = new User(usr, name, email, psswd);
            string result = AddUser(new List<User>()
                        {user});


        }
        public string AddUser(List<User> user)
        {
            string description = null;
            foreach (List<User> value in this.registered.Values)
            {
                if (user[0].Username == value[0].Username)
                {
                    description = "El nombre de usuario especificado ya existe";
                }
                else if (user[0].Username == value[0].Mail)
                {
                    description = "El correo ingresado ya existe";
                }
            }

            if (description == null)
            {
                this.registered.Add(registered.Count + 1, user);
            }
            return description;
        }
        public void ChangePassword(string usr, string pswd, string newPsswd)
        {
            string result = LogIn(usr, pswd);

            if (result == null)
            {
                foreach (List<User> user in this.registered.Values)
                {
                    if (user[0].Password == pswd)
                    {
                        user[0].Password = newPsswd;
                    }
                }

            }

        }
        public string LogIn(string usrname, string password)
        {
            string description = null;
            foreach (List<User> user in this.registered.Values)
            {
                if (user[0].Username == usrname && user[0].Password == password)
                {
                    if (user[0].Username == "Admin")
                    {
                        return "Admin";
                    }
                    return description;
                }
            }
            return description;
        }


    }

}
