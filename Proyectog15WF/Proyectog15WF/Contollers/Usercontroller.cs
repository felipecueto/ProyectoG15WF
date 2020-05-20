using CustomEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Proyectog15WF;

namespace Controllers
{
    public class UserController
    {
        List<User> users = new List<User>();
        AppForm view;

        public UserController(Form view)
        {
            this.view = view as AppForm;
            this.view.LoginButtonClicked += OnLoginButtonClicked;
            this.view.UserChecked += OnUserChecked;
            this.view.RegisterButtonClicked += OnRegisterButtonClicked;
            this.view.Checkusernameregister += OncheckUsernameregister;
        }


        public bool OnLoginButtonClicked(object sender, LoginEventArgs e)
        {
            User result = null;
            result = users.Where(t =>
               t.Username.ToUpper().Contains(e.UsernameText.ToUpper()) && (t.Password.ToUpper().Contains(e.PasswordText.ToUpper()))).FirstOrDefault();
            if (result is null)
            {
                return false;
            }
            else
            {
                return result.CheckCredentials(e.UsernameText, e.PasswordText);
            }

        }

        public void OnUserChecked(object sender, LoginEventArgs e)
        {
            User user = null;
            user = users.Where(t =>
               t.Username.ToUpper().Contains(e.UsernameText.ToUpper()) && (t.Password.ToUpper().Contains(e.PasswordText.ToUpper()))).FirstOrDefault();


        }
        public bool OnRegisterButtonClicked(object sender, RegisterEventArgs e)
        {
            users.Add(new User(e.Usernametext, e.Nametext, e.Email, e.Passwordtext));
            return true;

        }
        public string OncheckUsernameregister(object sender, RegisterEventArgs e)
        {
            string result = null;
            foreach (User user in users)
            {
                if (user.Username == e.Usernametext)
                {
                    result = user.Username;
                }

            }
            return result;

        }
    }
}   