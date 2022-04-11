using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            txtUserName.SelectAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string USERNAME = "admin";
            const string PASSWORD = "password123";


            
            if(txtUserName.Text == String.Empty || txtUserName.Text != USERNAME)
            {
                lblMessage.Text = ("Please enter the correct username");
                txtUserName.Focus();
                txtUserName.SelectAll();
            }
            else if(txtPassword.Text == String.Empty || txtPassword.Text != PASSWORD)
            {
                lblMessage.Text = ("Please enter the correct password");
                lblPassword.Focus();
                txtPassword.SelectAll();

            }
            else if(txtUserName.Text == USERNAME && txtPassword.Text == PASSWORD)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();

                mainForm.menuStripCOVIDData.Visible = true;
                mainForm.menuStripCountyDate.Visible = true;
                mainForm.menuStripLogout.Visible = true;
                mainForm.menuStripLogin.Visible = false;
                this.Close();
            }

        }
    }
}
