namespace AirlineManagementSystem
{
    partial class UserHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeHome = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtbxTo = new System.Windows.Forms.TextBox();
            this.groupBoxSearchFlight = new System.Windows.Forms.GroupBox();
            this.txtbxFrom = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.groupBoxFlightDetails = new System.Windows.Forms.GroupBox();
            this.lblHintFlightList2 = new System.Windows.Forms.Label();
            this.lblHintFlightList1 = new System.Windows.Forms.Label();
            this.btnFlightList = new System.Windows.Forms.Button();
            this.lblYourBookedFlight = new System.Windows.Forms.Label();
            this.lblFlightsDetails = new System.Windows.Forms.Label();
            this.dataGridViewBookedFlight = new System.Windows.Forms.DataGridView();
            this.dataGridViewFlightList = new System.Windows.Forms.DataGridView();
            this.groupBoxSearchFlight.SuspendLayout();
            this.groupBoxFlightDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookedFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeHome
            // 
            this.lblWelcomeHome.AutoSize = true;
            this.lblWelcomeHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcomeHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcomeHome.Location = new System.Drawing.Point(102, 50);
            this.lblWelcomeHome.Name = "lblWelcomeHome";
            this.lblWelcomeHome.Size = new System.Drawing.Size(800, 63);
            this.lblWelcomeHome.TabIndex = 0;
            this.lblWelcomeHome.Text = "Welcome To Airline Reservation";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Location = new System.Drawing.Point(573, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(919, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtbxTo
            // 
            this.txtbxTo.Location = new System.Drawing.Point(52, 27);
            this.txtbxTo.Name = "txtbxTo";
            this.txtbxTo.Size = new System.Drawing.Size(208, 20);
            this.txtbxTo.TabIndex = 4;
            // 
            // groupBoxSearchFlight
            // 
            this.groupBoxSearchFlight.Controls.Add(this.txtbxFrom);
            this.groupBoxSearchFlight.Controls.Add(this.lblFrom);
            this.groupBoxSearchFlight.Controls.Add(this.txtbxTo);
            this.groupBoxSearchFlight.Controls.Add(this.btnSearch);
            this.groupBoxSearchFlight.Controls.Add(this.lblTo);
            this.groupBoxSearchFlight.Location = new System.Drawing.Point(148, 143);
            this.groupBoxSearchFlight.Name = "groupBoxSearchFlight";
            this.groupBoxSearchFlight.Size = new System.Drawing.Size(708, 68);
            this.groupBoxSearchFlight.TabIndex = 6;
            this.groupBoxSearchFlight.TabStop = false;
            this.groupBoxSearchFlight.Text = "Search Filght";
            // 
            // txtbxFrom
            // 
            this.txtbxFrom.Location = new System.Drawing.Point(334, 27);
            this.txtbxFrom.Name = "txtbxFrom";
            this.txtbxFrom.Size = new System.Drawing.Size(220, 20);
            this.txtbxFrom.TabIndex = 5;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(292, 31);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 13);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From :";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(20, 30);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To :";
            // 
            // groupBoxFlightDetails
            // 
            this.groupBoxFlightDetails.Controls.Add(this.lblHintFlightList2);
            this.groupBoxFlightDetails.Controls.Add(this.lblHintFlightList1);
            this.groupBoxFlightDetails.Controls.Add(this.btnFlightList);
            this.groupBoxFlightDetails.Controls.Add(this.lblYourBookedFlight);
            this.groupBoxFlightDetails.Controls.Add(this.lblFlightsDetails);
            this.groupBoxFlightDetails.Controls.Add(this.dataGridViewBookedFlight);
            this.groupBoxFlightDetails.Controls.Add(this.dataGridViewFlightList);
            this.groupBoxFlightDetails.Location = new System.Drawing.Point(24, 217);
            this.groupBoxFlightDetails.Name = "groupBoxFlightDetails";
            this.groupBoxFlightDetails.Size = new System.Drawing.Size(986, 346);
            this.groupBoxFlightDetails.TabIndex = 7;
            this.groupBoxFlightDetails.TabStop = false;
            this.groupBoxFlightDetails.Text = "Flight Details";
            // 
            // lblHintFlightList2
            // 
            this.lblHintFlightList2.AutoSize = true;
            this.lblHintFlightList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintFlightList2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHintFlightList2.Location = new System.Drawing.Point(620, 309);
            this.lblHintFlightList2.Name = "lblHintFlightList2";
            this.lblHintFlightList2.Size = new System.Drawing.Size(156, 13);
            this.lblHintFlightList2.TabIndex = 17;
            this.lblHintFlightList2.Text = "**Payment Will Be In Cash";
            // 
            // lblHintFlightList1
            // 
            this.lblHintFlightList1.AutoSize = true;
            this.lblHintFlightList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintFlightList1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHintFlightList1.Location = new System.Drawing.Point(6, 309);
            this.lblHintFlightList1.Name = "lblHintFlightList1";
            this.lblHintFlightList1.Size = new System.Drawing.Size(257, 13);
            this.lblHintFlightList1.TabIndex = 16;
            this.lblHintFlightList1.Text = "**To Book Flight Click On The Specific Row";
            // 
            // btnFlightList
            // 
            this.btnFlightList.Location = new System.Drawing.Point(339, 304);
            this.btnFlightList.Name = "btnFlightList";
            this.btnFlightList.Size = new System.Drawing.Size(113, 23);
            this.btnFlightList.TabIndex = 15;
            this.btnFlightList.Text = "Show Flight List";
            this.btnFlightList.UseVisualStyleBackColor = true;
            this.btnFlightList.Click += new System.EventHandler(this.btnTodaysFlights_Click);
            // 
            // lblYourBookedFlight
            // 
            this.lblYourBookedFlight.AutoSize = true;
            this.lblYourBookedFlight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblYourBookedFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourBookedFlight.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblYourBookedFlight.Location = new System.Drawing.Point(666, 16);
            this.lblYourBookedFlight.Name = "lblYourBookedFlight";
            this.lblYourBookedFlight.Size = new System.Drawing.Size(110, 15);
            this.lblYourBookedFlight.TabIndex = 14;
            this.lblYourBookedFlight.Text = "Your Booked Flight";
            // 
            // lblFlightsDetails
            // 
            this.lblFlightsDetails.AutoSize = true;
            this.lblFlightsDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFlightsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightsDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFlightsDetails.Location = new System.Drawing.Point(180, 16);
            this.lblFlightsDetails.Name = "lblFlightsDetails";
            this.lblFlightsDetails.Size = new System.Drawing.Size(65, 15);
            this.lblFlightsDetails.TabIndex = 13;
            this.lblFlightsDetails.Text = "Flights List";
            // 
            // dataGridViewBookedFlight
            // 
            this.dataGridViewBookedFlight.AllowUserToAddRows = false;
            this.dataGridViewBookedFlight.AllowUserToDeleteRows = false;
            this.dataGridViewBookedFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookedFlight.Location = new System.Drawing.Point(471, 44);
            this.dataGridViewBookedFlight.Name = "dataGridViewBookedFlight";
            this.dataGridViewBookedFlight.ReadOnly = true;
            this.dataGridViewBookedFlight.Size = new System.Drawing.Size(509, 254);
            this.dataGridViewBookedFlight.TabIndex = 12;
            this.dataGridViewBookedFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookedFlight_CellContentClick);
            // 
            // dataGridViewFlightList
            // 
            this.dataGridViewFlightList.AllowUserToAddRows = false;
            this.dataGridViewFlightList.AllowUserToDeleteRows = false;
            this.dataGridViewFlightList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightList.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewFlightList.Name = "dataGridViewFlightList";
            this.dataGridViewFlightList.ReadOnly = true;
            this.dataGridViewFlightList.Size = new System.Drawing.Size(446, 254);
            this.dataGridViewFlightList.TabIndex = 11;
            this.dataGridViewFlightList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFlightList_CellClick);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1033, 575);
            this.Controls.Add(this.groupBoxFlightDetails);
            this.Controls.Add(this.groupBoxSearchFlight);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcomeHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserHome";
            this.Text = "User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.groupBoxSearchFlight.ResumeLayout(false);
            this.groupBoxSearchFlight.PerformLayout();
            this.groupBoxFlightDetails.ResumeLayout(false);
            this.groupBoxFlightDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookedFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label lblWelcomeHome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtbxTo;
        private System.Windows.Forms.GroupBox groupBoxSearchFlight;
        private System.Windows.Forms.TextBox txtbxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox groupBoxFlightDetails;
        private System.Windows.Forms.Label lblYourBookedFlight;
        private System.Windows.Forms.Label lblFlightsDetails;
        private System.Windows.Forms.DataGridView dataGridViewBookedFlight;
        private System.Windows.Forms.DataGridView dataGridViewFlightList;
        private System.Windows.Forms.Button btnFlightList;
        private System.Windows.Forms.Label lblHintFlightList1;
        private System.Windows.Forms.Label lblHintFlightList2;
    }
}