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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();

            ShowFlightList(); 
            ShowBookedFlights();
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
                else
                {
                    MessageBox.Show("Please insert different location in both field!");
                }
            }
            else
            {
                MessageBox.Show("Please Insert Location!");
            }
        }

        private void btnTodaysFlights_Click(object sender, EventArgs e)
        {
            ShowFlightList();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }


        private void ShowFlightList() {
            lblFlightsDetails.Text = "Flights";
            
            
            /*  Get Data From the Database  */

            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Airlines");
            dataTable.Columns.Add("Origin");
            dataTable.Columns.Add("Destination");
            dataTable.Columns.Add("Price");

            /*  Putting Some Demo Data In Data Grid View    */
            dataTable.Rows.Add("Qatar Airlines", "Bangladesh", "US", "70000");
            dataTable.Rows.Add("Bangladesh Biman", "Dhaka", "Chitagong", "8000");
            dataTable.Rows.Add("Bangladesh Biman", "Bangladesh", "Australia", "50000");

            dataGridViewFlightList.DataSource = dataTable;
        }

        private void ShowBookedFlights()
        {
            /*  Get Data From the Database  */


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Airlines");
            dataTable.Columns.Add("Origin");
            dataTable.Columns.Add("Destination");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Cancel");

            /*  Putting Some Demo Data In Data Grid View    */
            dataTable.Rows.Add("Bangladesh Biman", "Dhaka", "Chitagong", "8000", "Cancel");

            dataGridViewBookedFlight.DataSource = dataTable;
        }

        private void ShowSearchedFlights()
        {
            lblFlightsDetails.Text = "Searched Flights";
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

            dataGridViewFlightList.DataSource = dataTable;
        }

        private void dataGridViewFlightList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Row Index" + e.RowIndex +"Column Index: "+ e.ColumnIndex);
            if (e.RowIndex != -1)
            {
                try
                {
                    DataTable dataTable = (DataTable)dataGridViewBookedFlight.DataSource;

                    DataRow drToAdd = dataTable.NewRow();
                    drToAdd["Airlines"] = dataGridViewFlightList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    drToAdd["Origin"] = dataGridViewFlightList.Rows[e.RowIndex].Cells[1].Value.ToString();
                    drToAdd["Destination"] = dataGridViewFlightList.Rows[e.RowIndex].Cells[2].Value.ToString();
                    drToAdd["Price"] = dataGridViewFlightList.Rows[e.RowIndex].Cells[3].Value.ToString();
                    drToAdd["Cancel"] = "Cancel";

                    dataTable.Rows.Add(drToAdd);
                    dataTable.AcceptChanges();
                    dataGridViewBookedFlight.DataSource = dataTable;

                    // throw new Exception();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc + "");
                }
            }
        }

        private void dataGridViewBookedFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Row Index" + e.RowIndex +"Column Index: "+ e.ColumnIndex);
            if (e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                try
                {
                    dataGridViewBookedFlight.Rows.RemoveAt(e.RowIndex);

                   // throw new Exception();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc + "");
                }
            }
        }
    }
}
