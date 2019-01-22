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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!txtbxEmail.Text.Trim().Equals("") && !txtbxPassword.Text.Trim().Equals("") && !txtbxConfirmPassword.Text.Trim().Equals(""))
            {
                /* Database query to know user validity */

                /* Insert new password into Database using query */



                /* If Password changed give this message */
                MessageBox.Show("Password successfully changed!");


                new Login().Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Please fill fields properly!");
            }
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
