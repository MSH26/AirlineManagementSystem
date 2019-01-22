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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!txtbxPassengerName.Text.Trim().Equals("") && !txtbxContactNo.Text.Trim().Equals("") && !txtbxPasword.Text.Trim().Equals("") && !txtbxConfirmPasword.Text.Trim().Equals("") && !txtbxEmail.Text.Trim().Equals(""))
            {
                /* Insert new passenger details into Database using query */

                new Login().Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Please fill fields properly!");
            }            
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

    }
}
