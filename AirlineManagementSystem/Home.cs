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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ShowSearchedFlights()
        {
            txtbxTo.Text = "";
            txtbxFrom.Text = "";


            /*  Get Data From the Database  */


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Airlines");
            dataTable.Columns.Add("Origin");
            dataTable.Columns.Add("Destination");
            dataTable.Columns.Add("Price");

            /*  Putting Some Demo Data In Data Grid View    */
            dataTable.Rows.Add("Bangladesh Biman", "Dhaka", "Chitagong", "8000");

            DataGridView dataGridViewFlightList = new DataGridView();
            dataGridViewFlightList.AllowUserToAddRows = false;
            dataGridViewFlightList.AllowUserToDeleteRows = false;
            dataGridViewFlightList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFlightList.Location = new System.Drawing.Point(200, 250);
            dataGridViewFlightList.Name = "dataGridViewSearchedFlightList";
            dataGridViewFlightList.ReadOnly = true;
            dataGridViewFlightList.Size = new System.Drawing.Size(450, 180);
            this.Controls.Add(dataGridViewFlightList);

            dataGridViewFlightList.DataSource = dataTable;

            Label lblHint = new Label();
            lblHint.Location = new System.Drawing.Point(240, 440);
            lblHint.Name = "lblHint";
            lblHint.Size = new System.Drawing.Size(350, 25);
            lblHint.Text = "**To Book A Flight You Have To Login";
            this.Controls.Add(lblHint);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtbxFrom.Text.Trim().Equals("") && !txtbxTo.Text.Trim().Equals(""))
            {
                if (!txtbxFrom.Text.Trim().Equals(txtbxTo.Text.Trim()))
                {
                    ShowSearchedFlights();
                }
                else {
                    MessageBox.Show("Please insert different location in both field!");
                }
            }
            else {
                MessageBox.Show("Please Insert Location!");
            }           
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
