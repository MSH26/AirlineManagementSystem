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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            ShowFlightList();
            ShowBookingRequest();
            ShowApprovedBookingRequest();
            ShowCancelledBookingRequest();
            InitiateFlightControlGroupBox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowFlightList()
        {
            /*  Get Data From the Database  */


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FS_Id");
            dataTable.Columns.Add("Airlines");
            dataTable.Columns.Add("Origin");
            dataTable.Columns.Add("Destination");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Take Off Time");
            dataTable.Columns.Add("Aircraft_Id");
            dataTable.Columns.Add("Total Seat");
            dataTable.Columns.Add("Seat reserved");

            /*  Putting Some Demo Data In Data Grid View    */
            dataTable.Rows.Add("F-000012-01", "Qatar Airlines", "Bangladesh", "US", "70000", "1:30 am", "A-100000024-1", "322", "152");
            dataTable.Rows.Add("F-000011-01", "Bangladesh Biman", "Bangladesh", "US", "65000", "11:30 am", "A-100000020-1", "252", "186");
            dataTable.Rows.Add("F-000009-02", "China Biman", "China", "US", "56000", "1:30 pm", "A-100000014-1", "352", "153");

            dataGridViewFlightList.DataSource = dataTable;
        }

        private void ShowBookingRequest()
        {
            /*  Get Data From the Database  */


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FS_Id");
            dataTable.Columns.Add("Passenger Id");
            dataTable.Columns.Add("Passenger Name");
            dataTable.Columns.Add("Origin");
            dataTable.Columns.Add("Destination");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Booking Quantity");
            dataTable.Columns.Add("Approve");
            dataTable.Columns.Add("Cancel");

            /*  Putting Some Demo Data In Data Grid View    */
            dataTable.Rows.Add("F-000012-01", "P-100000001-01", "Isshon Saha", "Bangladesh", "US", "70000", "1", "Approve", "Cancel");

            dataGridViewBookedFlight.DataSource = dataTable;
        }

        private void ShowApprovedBookingRequest()
        {
            /*  Get Data From the Database  */


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FS_Id");
            dataTable.Columns.Add("Passenger Id");
            dataTable.Columns.Add("Passenger Name");
            dataTable.Columns.Add("Origin");
            dataTable.Columns.Add("Destination");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Booking Quantity");
            dataTable.Columns.Add("Status");

            /*  Putting Some Demo Data In Data Grid View    */
            dataTable.Rows.Add("F-000011-01", "P-100000002-01", "Rabby Noor Rahman", "Bangladesh", "US", "70000", "1", "Approved");

            dataGridViewApprovedFlightBookingRequests.DataSource = dataTable;
        }

        private void ShowCancelledBookingRequest()
        {
            /*  Get Data From the Database  */


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("FS_Id");
            dataTable.Columns.Add("Passenger Id");
            dataTable.Columns.Add("Passenger Name");
            dataTable.Columns.Add("Origin");
            dataTable.Columns.Add("Destination");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Booking Quantity");
            dataTable.Columns.Add("Status");

            /*  Putting Some Demo Data In Data Grid View    */
            dataTable.Rows.Add("F-000012-01", "P-100000003-01", "Md. Sakib Hossain", "Dhaka", "Chitagong", "8000", "1", "Cancelled");

            dataGridViewCencelledFlightBookingRequests.DataSource = dataTable;
        }

        private void InitiateFlightControlGroupBox() { 
            //  For Flight Schedule

            /*  Take Route  data from database */
            comboBoxAddFlightScheduleAddFlightSelectRoute.Items.Add("Route:" + "Dhaka-Chitagong"+ "|| Cost:" + "8000");
            comboBoxAddFlightScheduleAddFlightSelectRoute.Items.Add("Route:" + "Bangladesh-US" + "|| Cost:" + "70000");

            /*  Take Aircraft  data from database */
            comboBoxAddFlightScheduleSelectAircraft.Items.Add("ID:" + "A-100000020-1");
            comboBoxAddFlightScheduleSelectAircraft.Items.Add("ID:" + "A-100000024-1");

            //  For Aircraft

            /*  Take Route  data from database */
            comboBoxAddAircraftAirlines.Items.Add("Bangladesh Biman");
            comboBoxAddAircraftAirlines.Items.Add("Qatar Airlines");
            comboBoxAddAircraftAirlines.Items.Add("China Biman");
        }

        private void InitiateEmplyeeManagement()
        {
            //  For Employee List

            /*  Get Data From the Database  */


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("NID");
            dataTable.Columns.Add("Branch");

            /*  Putting Some Demo Data In Data Grid View    */
            dataTable.Rows.Add("E-000012-01", "Shadat Abu Rocky", "19931354843513", "Dhaka-Bangladesh");

            dataGridViewEmployeeList.DataSource = dataTable;

            /*  Take Branch  data from database */
            comboBoxRegisterEmployeeBranch.Items.Add("Dhaka-Bangladesh");
            comboBoxRegisterEmployeeBranch.Items.Add("Newyork-US");
            comboBoxRegisterEmployeeBranch.Items.Add("Delhi-India");

        }

        private void dataGridViewBookedFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    if (e.ColumnIndex == 7)
                    {
                        /*  Set the status of that booking request as cancelled in database    */


                        DataTable dataTable = (DataTable)dataGridViewApprovedFlightBookingRequests.DataSource;

                        DataRow drToAdd = dataTable.NewRow();
                        drToAdd["FS_Id"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[0].Value.ToString();
                        drToAdd["Passenger Id"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[1].Value.ToString();
                        drToAdd["Passenger Name"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[2].Value.ToString();
                        drToAdd["Origin"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[3].Value.ToString();
                        drToAdd["Destination"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[4].Value.ToString();
                        drToAdd["Price"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[5].Value.ToString();
                        drToAdd["Booking Quantity"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[6].Value.ToString();
                        drToAdd["Status"] = "Approved";

                        dataTable.Rows.Add(drToAdd);
                        dataTable.AcceptChanges();
                        dataGridViewApprovedFlightBookingRequests.DataSource = dataTable;

                        dataGridViewBookedFlight.Rows.RemoveAt(e.RowIndex);

                        //MessageBox.Show("Row Index" + e.RowIndex +"Column Index: "+ e.ColumnIndex);
                    }
                    else if (e.ColumnIndex == 8)
                    {
                        /*  Set the status of that booking request as cancelled in database    */


                        DataTable dataTable = (DataTable)dataGridViewCencelledFlightBookingRequests.DataSource;

                        DataRow drToAdd = dataTable.NewRow();
                        drToAdd["FS_Id"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[0].Value.ToString();
                        drToAdd["Passenger Id"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[1].Value.ToString();
                        drToAdd["Passenger Name"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[2].Value.ToString();
                        drToAdd["Origin"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[3].Value.ToString();
                        drToAdd["Destination"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[4].Value.ToString();
                        drToAdd["Price"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[5].Value.ToString();
                        drToAdd["Booking Quantity"] = dataGridViewBookedFlight.Rows[e.RowIndex].Cells[6].Value.ToString();
                        drToAdd["Status"] = "Cancelled";

                        dataTable.Rows.Add(drToAdd);
                        dataTable.AcceptChanges();
                        dataGridViewCencelledFlightBookingRequests.DataSource = dataTable;

                        dataGridViewBookedFlight.Rows.RemoveAt(e.RowIndex);

                        //MessageBox.Show("Row Index" + e.RowIndex +"Column Index: "+ e.ColumnIndex);
                    }

                    // throw new Exception();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc + "");
                }
            }
        }

        private void btnFlightDetailsSearch_Click(object sender, EventArgs e)
        {
            if (!txtbxFlightDetailsSearch.Text.Trim().Equals(""))
            {
                /* Check the existance of the flight schedule from database */

                /* Remaining code will be like the ShowFlightList() method*/

                MessageBox.Show("Fake Message!!!");
            }
            else {
                MessageBox.Show("Fill the field");
            }
        }

        private void btnShowFlightDetails_Click(object sender, EventArgs e)
        {
            ShowFlightList();
        }

        private void btnAddRouteAdd_Click(object sender, EventArgs e)
        {
            if (!txtbxAddRouteOrigin.Text.Trim().Equals("") && !txtbxAddRouteDestination.Text.Trim().Equals("") && !txtbxAddRouteCost.Text.Trim().Equals(""))
            {
                /*  Insert route into databse   */

                /*  Insert route cost into databse   */

                MessageBox.Show("New Route Added!!!");
            }
            else {
                MessageBox.Show("Please fill all the field!!!");
            }
        }

        private void btnAddAirlinesAdd_Click(object sender, EventArgs e)
        {
            if (!txtbxAddAirlinesName.Text.Trim().Equals(""))
            {
                /*  Insert airlines details into databse   */


                MessageBox.Show("New Airlines Added!!!");
            }
            else {
                MessageBox.Show("Please fill all the field!!!");
            }
        }

        private void btnAddAircraftAdd_Click(object sender, EventArgs e)
        {
            /* Implement Yoursef friend */
        }

        private void btnAddFlightScheduleAdd_Click(object sender, EventArgs e)
        {
            /* Implement Yoursef friend */
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {

        }

    }
}
