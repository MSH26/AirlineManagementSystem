using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtbxName.Text.Trim().Equals("") && !txtbxPassword.Text.Trim().Equals(""))
            {
                /* Database query to know user validity */


                if(txtbxName.Text.Trim().Equals("user") && txtbxPassword.Text.Trim().Equals("user")){
                    new UserHome().Show();
                    this.Hide();
                }
                else if(txtbxName.Text.Trim().Equals("admin") && txtbxPassword.Text.Trim().Equals("admin")){
                    new AdminHome().Show();
                    this.Hide();
                }
                else if (txtbxName.Text.Trim().Equals("employee") && txtbxPassword.Text.Trim().Equals("employee"))
                {
                    new EmployeeHome().Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Not A Valid User! Please Do Registeration!!");
                }
            }
            else {
                MessageBox.Show("Please fill fields properly!");
            }
        }

        private void lblforgotPassword_Click(object sender, EventArgs e)
        {
            new ForgotPassword().Show();
            this.Hide();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

    }
}
