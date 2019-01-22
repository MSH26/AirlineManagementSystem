namespace AirlineManagementSystem
{
    partial class Home
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.txtbxTo = new System.Windows.Forms.TextBox();
            this.groupBoxSearchFlight = new System.Windows.Forms.GroupBox();
            this.txtbxFrom = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.groupBoxSearchFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeHome
            // 
            this.lblWelcomeHome.AutoSize = true;
            this.lblWelcomeHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcomeHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcomeHome.Location = new System.Drawing.Point(29, 60);
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
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(692, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(773, 12);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(75, 23);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
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
            this.groupBoxSearchFlight.Location = new System.Drawing.Point(73, 173);
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
            // btnCloseApplication
            // 
            this.btnCloseApplication.Location = new System.Drawing.Point(12, 12);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(107, 23);
            this.btnCloseApplication.TabIndex = 7;
            this.btnCloseApplication.Text = "Close Application";
            this.btnCloseApplication.UseVisualStyleBackColor = true;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 472);
            this.Controls.Add(this.btnCloseApplication);
            this.Controls.Add(this.groupBoxSearchFlight);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWelcomeHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.Text = "Airline";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.groupBoxSearchFlight.ResumeLayout(false);
            this.groupBoxSearchFlight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeHome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.TextBox txtbxTo;
        private System.Windows.Forms.GroupBox groupBoxSearchFlight;
        private System.Windows.Forms.TextBox txtbxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnCloseApplication;
    }
}