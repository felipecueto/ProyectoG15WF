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
        public AppForm()
        {
            InitializeComponent();
            
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
    }
}
