﻿
using CustomEventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectog15WF
{

    public partial class AppForm : Form
    {
        public delegate bool LoginEventHandler(object source, LoginEventArgs args);
        public event LoginEventHandler LoginButtonClicked;
        public event EventHandler<LoginEventArgs> UserChecked;
        public delegate bool RegisterEventHandler(object source, RegisterEventArgs args);
        public event RegisterEventHandler RegisterButtonClicked;



        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();
        public AppForm()
        {

            InitializeComponent();
            panels.Add("StartPanel", StartPanel);
            panels.Add("Registerpanel", RegisterPanel);
            panels.Add("LoginPanel", LoginPanel);


        }
        private void loginViewButton_Click(object sender, EventArgs e)
        {

        }

        private void SOPTLOGO_Click(object sender, EventArgs e)
        {

        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void RegistrateButton_Click(object sender, EventArgs e)
        {
            StartPanel.SendToBack();
            RegisterPanel.BringToFront();
            RegisterPanel.Visible = true;

        }

        private void BackButtonLogin_Click(object sender, EventArgs e)
        {
            LoginPanel.SendToBack();
            StartPanel.BringToFront();
            LoginPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPanel.SendToBack();
            LoginPanel.BringToFront();
            LoginPanel.Visible = true;
        }

        private void BackRegisterButton_Click(object sender, EventArgs e)
        {
            RegisterPanel.SendToBack();
            StartPanel.BringToFront();
            RegisterPanel.Visible = false;
        }

        private void IniciarseccionLabelLogin_Click(object sender, EventArgs e)
        {

        }

        private void IniciarseccionLabelLogin_Click_1(object sender, EventArgs e)
        {

        }
        private void OnLoginButtonClicked(string username, string pass)
        {
            if (LoginButtonClicked != null)
            {
                bool result = LoginButtonClicked(this, new LoginEventArgs() { UsernameText = username, PasswordText = pass });
                if (!result)
                {
                    UsernameInPutLogin.ResetText();
                    PasswordInPutLogin.ResetText();
                    loginViewInvalidCredentialsAlert.Text = "Credenciales invalidas";
                    loginViewInvalidCredentialsAlert.Visible = true;
                }
                else
                {
                    loginViewInvalidCredentialsAlert.ResetText();
                    loginViewInvalidCredentialsAlert.Visible = false;
                    OnUserChecked(username, pass);
                }
            }
        }
        private void OnUserChecked(string username, string password)
        {
            if (UserChecked != null)
            {
                UserChecked(this, new LoginEventArgs() { UsernameText = username, PasswordText = password });
                UsernameInPutLogin.ResetText();
                PasswordInPutLogin.ResetText();
                stackPanels.Add(panels["StartPanel"]);
                ShowLastPanel();
            }
        }

        public void Onregisteredbutooncliked(string Name, string Lastname, string Username, string Mailuser, string Passworduser)
        {
            if (RegisterButtonClicked != null)
            {
                bool result = RegisterButtonClicked(this, new RegisterEventArgs() { Usernametext = Username, Passwordtext = Passworduser });
                if (result)
                {
                    nameInputRegister.ResetText();
                    LastNameInputRegister.ResetText();
                    UsernameInputRegister.ResetText();
                    MailInputRegister.ResetText();
                    PasswordInputRegister.ResetText();
                    stackPanels.Add(panels["StartPanel"]);
                    ShowLastPanel();
                }
            }

        }
        private void ShowLastPanel()
        {
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackPanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
        }

        private void InicioLoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameInPutLogin.Text;
            string pass = PasswordInPutLogin.Text;
            OnLoginButtonClicked(username, pass);
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            string nameInputuser = null;
            string lastNameInputuser = null;
            string usernameInputuser = null;
            string mailInputuser = null;
            string passwordInputUser = null;
            int count = 0;
            if (count == 0)
            {
                nameInputuser = nameInputRegister.Text;
                if (nameInputuser == "")
                {
                    MessageBox.Show("Usuario incorrecto");
                }
                else
                {
                    count++;
                }
                lastNameInputuser = LastNameInputRegister.Text;
                if (lastNameInputuser == "")
                {
                    MessageBox.Show("Apellido incorrecto");
                }
                else
                {
                    count++;
                }
                usernameInputuser = UsernameInputRegister.Text;
                if (usernameInputuser == "")
                {
                    MessageBox.Show("Nombre usuario incorrecto");
                }
                else
                {
                    count++;
                }

                mailInputuser = MailInputRegister.Text;
                if (mailInputuser == "")
                {
                    MessageBox.Show("Mail incorrecto");
                }
                else
                {
                    count++;
                }

                passwordInputUser = PasswordInputRegister.Text;
                if (passwordInputUser == "" | passwordInputUser.Length < 8)
                {
                    MessageBox.Show("Su contraseña debe ser de largo 8 o mas");

                }
                else
                {
                    count++;
                }
                if (count == 5)
                {
                    Onregisteredbutooncliked(nameInputuser, lastNameInputuser, usernameInputuser, mailInputuser, passwordInputUser);
                    MessageBox.Show("Gracias por unirte a SpotFlix" + " " + usernameInputuser);
                    count = 0;
                }



            }



        }

    }
}
