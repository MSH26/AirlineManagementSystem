namespace AirlineManagementSystem
{
    partial class EmployeeHome
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControlFlightOperation = new System.Windows.Forms.TabControl();
            this.tabPageFlightDetails = new System.Windows.Forms.TabPage();
            this.btnShowFlightDetails = new System.Windows.Forms.Button();
            this.btnFlightDetailsSearch = new System.Windows.Forms.Button();
            this.txtbxFlightDetailsSearch = new System.Windows.Forms.TextBox();
            this.lblFlightDetailsSearch = new System.Windows.Forms.Label();
            this.lblFlightsDetails = new System.Windows.Forms.Label();
            this.dataGridViewFlightList = new System.Windows.Forms.DataGridView();
            this.tabPageBookingRequest = new System.Windows.Forms.TabPage();
            this.lblFlightBookingRequests = new System.Windows.Forms.Label();
            this.dataGridViewBookedFlight = new System.Windows.Forms.DataGridView();
            this.tabPageApprovedBookingRequests = new System.Windows.Forms.TabPage();
            this.lblApprovedFlightBookingRequests = new System.Windows.Forms.Label();
            this.dataGridViewApprovedFlightBookingRequests = new System.Windows.Forms.DataGridView();
            this.tabPageCancelledBookingRequests = new System.Windows.Forms.TabPage();
            this.lblCencelledFlightBookingRequests = new System.Windows.Forms.Label();
            this.dataGridViewCencelledFlightBookingRequests = new System.Windows.Forms.DataGridView();
            this.tabControlFlightOperation.SuspendLayout();
            this.tabPageFlightDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightList)).BeginInit();
            this.tabPageBookingRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookedFlight)).BeginInit();
            this.tabPageApprovedBookingRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApprovedFlightBookingRequests)).BeginInit();
            this.tabPageCancelledBookingRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCencelledFlightBookingRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeHome
            // 
            this.lblWelcomeHome.AutoSize = true;
            this.lblWelcomeHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcomeHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcomeHome.Location = new System.Drawing.Point(71, 48);
            this.lblWelcomeHome.Name = "lblWelcomeHome";
            this.lblWelcomeHome.Size = new System.Drawing.Size(800, 63);
            this.lblWelcomeHome.TabIndex = 0;
            this.lblWelcomeHome.Text = "Welcome To Airline Reservation";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(854, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControlFlightOperation
            // 
            this.tabControlFlightOperation.Controls.Add(this.tabPageFlightDetails);
            this.tabControlFlightOperation.Controls.Add(this.tabPageBookingRequest);
            this.tabControlFlightOperation.Controls.Add(this.tabPageApprovedBookingRequests);
            this.tabControlFlightOperation.Controls.Add(this.tabPageCancelledBookingRequests);
            this.tabControlFlightOperation.Location = new System.Drawing.Point(12, 129);
            this.tabControlFlightOperation.Name = "tabControlFlightOperation";
            this.tabControlFlightOperation.SelectedIndex = 0;
            this.tabControlFlightOperation.Size = new System.Drawing.Size(927, 434);
            this.tabControlFlightOperation.TabIndex = 7;
            // 
            // tabPageFlightDetails
            // 
            this.tabPageFlightDetails.Controls.Add(this.btnShowFlightDetails);
            this.tabPageFlightDetails.Controls.Add(this.btnFlightDetailsSearch);
            this.tabPageFlightDetails.Controls.Add(this.txtbxFlightDetailsSearch);
            this.tabPageFlightDetails.Controls.Add(this.lblFlightDetailsSearch);
            this.tabPageFlightDetails.Controls.Add(this.lblFlightsDetails);
            this.tabPageFlightDetails.Controls.Add(this.dataGridViewFlightList);
            this.tabPageFlightDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlightDetails.Name = "tabPageFlightDetails";
            this.tabPageFlightDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlightDetails.Size = new System.Drawing.Size(919, 408);
            this.tabPageFlightDetails.TabIndex = 0;
            this.tabPageFlightDetails.Text = "Flight Details";
            this.tabPageFlightDetails.UseVisualStyleBackColor = true;
            // 
            // btnShowFlightDetails
            // 
            this.btnShowFlightDetails.Location = new System.Drawing.Point(780, 50);
            this.btnShowFlightDetails.Name = "btnShowFlightDetails";
            this.btnShowFlightDetails.Size = new System.Drawing.Size(75, 23);
            this.btnShowFlightDetails.TabIndex = 5;
            this.btnShowFlightDetails.Text = "Show Flight Details";
            this.btnShowFlightDetails.UseVisualStyleBackColor = true;
            this.btnShowFlightDetails.Click += new System.EventHandler(this.btnShowFlightDetails_Click);
            // 
            // btnFlightDetailsSearch
            // 
            this.btnFlightDetailsSearch.Location = new System.Drawing.Point(568, 50);
            this.btnFlightDetailsSearch.Name = "btnFlightDetailsSearch";
            this.btnFlightDetailsSearch.Size = new System.Drawing.Size(75, 23);
            this.btnFlightDetailsSearch.TabIndex = 4;
            this.btnFlightDetailsSearch.Text = "Search";
            this.btnFlightDetailsSearch.UseVisualStyleBackColor = true;
            this.btnFlightDetailsSearch.Click += new System.EventHandler(this.btnFlightDetailsSearch_Click);
            // 
            // txtbxFlightDetailsSearch
            // 
            this.txtbxFlightDetailsSearch.Location = new System.Drawing.Point(250, 52);
            this.txtbxFlightDetailsSearch.Name = "txtbxFlightDetailsSearch";
            this.txtbxFlightDetailsSearch.Size = new System.Drawing.Size(294, 20);
            this.txtbxFlightDetailsSearch.TabIndex = 3;
            // 
            // lblFlightDetailsSearch
            // 
            this.lblFlightDetailsSearch.AutoSize = true;
            this.lblFlightDetailsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDetailsSearch.Location = new System.Drawing.Point(81, 53);
            this.lblFlightDetailsSearch.Name = "lblFlightDetailsSearch";
            this.lblFlightDetailsSearch.Size = new System.Drawing.Size(163, 15);
            this.lblFlightDetailsSearch.TabIndex = 2;
            this.lblFlightDetailsSearch.Text = "Search Flight by FS_Id : ";
            // 
            // lblFlightsDetails
            // 
            this.lblFlightsDetails.AutoSize = true;
            this.lblFlightsDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightsDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFlightsDetails.Location = new System.Drawing.Point(389, 17);
            this.lblFlightsDetails.Name = "lblFlightsDetails";
            this.lblFlightsDetails.Size = new System.Drawing.Size(111, 17);
            this.lblFlightsDetails.TabIndex = 1;
            this.lblFlightsDetails.Text = "Flights Details";
            // 
            // dataGridViewFlightList
            // 
            this.dataGridViewFlightList.AllowUserToAddRows = false;
            this.dataGridViewFlightList.AllowUserToDeleteRows = false;
            this.dataGridViewFlightList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightList.Location = new System.Drawing.Point(6, 88);
            this.dataGridViewFlightList.Name = "dataGridViewFlightList";
            this.dataGridViewFlightList.ReadOnly = true;
            this.dataGridViewFlightList.Size = new System.Drawing.Size(907, 305);
            this.dataGridViewFlightList.TabIndex = 0;
            // 
            // tabPageBookingRequest
            // 
            this.tabPageBookingRequest.Controls.Add(this.lblFlightBookingRequests);
            this.tabPageBookingRequest.Controls.Add(this.dataGridViewBookedFlight);
            this.tabPageBookingRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookingRequest.Name = "tabPageBookingRequest";
            this.tabPageBookingRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBookingRequest.Size = new System.Drawing.Size(919, 408);
            this.tabPageBookingRequest.TabIndex = 1;
            this.tabPageBookingRequest.Text = "Booking Request";
            this.tabPageBookingRequest.UseVisualStyleBackColor = true;
            // 
            // lblFlightBookingRequests
            // 
            this.lblFlightBookingRequests.AutoSize = true;
            this.lblFlightBookingRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightBookingRequests.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFlightBookingRequests.Location = new System.Drawing.Point(362, 17);
            this.lblFlightBookingRequests.Name = "lblFlightBookingRequests";
            this.lblFlightBookingRequests.Size = new System.Drawing.Size(184, 17);
            this.lblFlightBookingRequests.TabIndex = 2;
            this.lblFlightBookingRequests.Text = "Flight Booking Requests";
            // 
            // dataGridViewBookedFlight
            // 
            this.dataGridViewBookedFlight.AllowUserToAddRows = false;
            this.dataGridViewBookedFlight.AllowUserToDeleteRows = false;
            this.dataGridViewBookedFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookedFlight.Location = new System.Drawing.Point(6, 49);
            this.dataGridViewBookedFlight.Name = "dataGridViewBookedFlight";
            this.dataGridViewBookedFlight.ReadOnly = true;
            this.dataGridViewBookedFlight.Size = new System.Drawing.Size(907, 342);
            this.dataGridViewBookedFlight.TabIndex = 0;
            this.dataGridViewBookedFlight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookedFlight_CellClick);
            // 
            // tabPageApprovedBookingRequests
            // 
            this.tabPageApprovedBookingRequests.Controls.Add(this.lblApprovedFlightBookingRequests);
            this.tabPageApprovedBookingRequests.Controls.Add(this.dataGridViewApprovedFlightBookingRequests);
            this.tabPageApprovedBookingRequests.Location = new System.Drawing.Point(4, 22);
            this.tabPageApprovedBookingRequests.Name = "tabPageApprovedBookingRequests";
            this.tabPageApprovedBookingRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApprovedBookingRequests.Size = new System.Drawing.Size(919, 408);
            this.tabPageApprovedBookingRequests.TabIndex = 2;
            this.tabPageApprovedBookingRequests.Text = "Approved Booking Requests";
            this.tabPageApprovedBookingRequests.UseVisualStyleBackColor = true;
            // 
            // lblApprovedFlightBookingRequests
            // 
            this.lblApprovedFlightBookingRequests.AutoSize = true;
            this.lblApprovedFlightBookingRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovedFlightBookingRequests.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApprovedFlightBookingRequests.Location = new System.Drawing.Point(341, 16);
            this.lblApprovedFlightBookingRequests.Name = "lblApprovedFlightBookingRequests";
            this.lblApprovedFlightBookingRequests.Size = new System.Drawing.Size(258, 17);
            this.lblApprovedFlightBookingRequests.TabIndex = 4;
            this.lblApprovedFlightBookingRequests.Text = "Approved Flight Booking Requests";
            // 
            // dataGridViewApprovedFlightBookingRequests
            // 
            this.dataGridViewApprovedFlightBookingRequests.AllowUserToAddRows = false;
            this.dataGridViewApprovedFlightBookingRequests.AllowUserToDeleteRows = false;
            this.dataGridViewApprovedFlightBookingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApprovedFlightBookingRequests.Location = new System.Drawing.Point(6, 49);
            this.dataGridViewApprovedFlightBookingRequests.Name = "dataGridViewApprovedFlightBookingRequests";
            this.dataGridViewApprovedFlightBookingRequests.ReadOnly = true;
            this.dataGridViewApprovedFlightBookingRequests.Size = new System.Drawing.Size(907, 342);
            this.dataGridViewApprovedFlightBookingRequests.TabIndex = 3;
            // 
            // tabPageCancelledBookingRequests
            // 
            this.tabPageCancelledBookingRequests.Controls.Add(this.lblCencelledFlightBookingRequests);
            this.tabPageCancelledBookingRequests.Controls.Add(this.dataGridViewCencelledFlightBookingRequests);
            this.tabPageCancelledBookingRequests.Location = new System.Drawing.Point(4, 22);
            this.tabPageCancelledBookingRequests.Name = "tabPageCancelledBookingRequests";
            this.tabPageCancelledBookingRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCancelledBookingRequests.Size = new System.Drawing.Size(919, 408);
            this.tabPageCancelledBookingRequests.TabIndex = 3;
            this.tabPageCancelledBookingRequests.Text = "Cancelled Booking Requests";
            this.tabPageCancelledBookingRequests.UseVisualStyleBackColor = true;
            // 
            // lblCencelledFlightBookingRequests
            // 
            this.lblCencelledFlightBookingRequests.AutoSize = true;
            this.lblCencelledFlightBookingRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCencelledFlightBookingRequests.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCencelledFlightBookingRequests.Location = new System.Drawing.Point(352, 17);
            this.lblCencelledFlightBookingRequests.Name = "lblCencelledFlightBookingRequests";
            this.lblCencelledFlightBookingRequests.Size = new System.Drawing.Size(260, 17);
            this.lblCencelledFlightBookingRequests.TabIndex = 4;
            this.lblCencelledFlightBookingRequests.Text = "Cancelled Flight Booking Requests";
            // 
            // dataGridViewCencelledFlightBookingRequests
            // 
            this.dataGridViewCencelledFlightBookingRequests.AllowUserToAddRows = false;
            this.dataGridViewCencelledFlightBookingRequests.AllowUserToDeleteRows = false;
            this.dataGridViewCencelledFlightBookingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCencelledFlightBookingRequests.Location = new System.Drawing.Point(6, 49);
            this.dataGridViewCencelledFlightBookingRequests.Name = "dataGridViewCencelledFlightBookingRequests";
            this.dataGridViewCencelledFlightBookingRequests.ReadOnly = true;
            this.dataGridViewCencelledFlightBookingRequests.Size = new System.Drawing.Size(907, 342);
            this.dataGridViewCencelledFlightBookingRequests.TabIndex = 3;
            // 
            // EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 575);
            this.Controls.Add(this.tabControlFlightOperation);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcomeHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmployeeHome";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.tabControlFlightOperation.ResumeLayout(false);
            this.tabPageFlightDetails.ResumeLayout(false);
            this.tabPageFlightDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightList)).EndInit();
            this.tabPageBookingRequest.ResumeLayout(false);
            this.tabPageBookingRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookedFlight)).EndInit();
            this.tabPageApprovedBookingRequests.ResumeLayout(false);
            this.tabPageApprovedBookingRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApprovedFlightBookingRequests)).EndInit();
            this.tabPageCancelledBookingRequests.ResumeLayout(false);
            this.tabPageCancelledBookingRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCencelledFlightBookingRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label lblWelcomeHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControlFlightOperation;
        private System.Windows.Forms.TabPage tabPageFlightDetails;
        private System.Windows.Forms.TabPage tabPageBookingRequest;
        private System.Windows.Forms.DataGridView dataGridViewFlightList;
        private System.Windows.Forms.DataGridView dataGridViewBookedFlight;
        private System.Windows.Forms.Label lblFlightsDetails;
        private System.Windows.Forms.Label lblFlightBookingRequests;
        private System.Windows.Forms.Button btnFlightDetailsSearch;
        private System.Windows.Forms.TextBox txtbxFlightDetailsSearch;
        private System.Windows.Forms.Label lblFlightDetailsSearch;
        private System.Windows.Forms.TabPage tabPageApprovedBookingRequests;
        private System.Windows.Forms.TabPage tabPageCancelledBookingRequests;
        private System.Windows.Forms.Label lblApprovedFlightBookingRequests;
        private System.Windows.Forms.DataGridView dataGridViewApprovedFlightBookingRequests;
        private System.Windows.Forms.Label lblCencelledFlightBookingRequests;
        private System.Windows.Forms.DataGridView dataGridViewCencelledFlightBookingRequests;
        private System.Windows.Forms.Button btnShowFlightDetails;
    }
}