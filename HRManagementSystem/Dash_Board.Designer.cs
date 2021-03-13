
namespace HRManagementSystem
{
    partial class Dash_Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash_Board));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbHeadings = new System.Windows.Forms.TextBox();
            this.hrms = new System.Windows.Forms.Label();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.departmentbtn = new System.Windows.Forms.Button();
            this.employeebtn = new System.Windows.Forms.Button();
            this.Vacationbtn = new System.Windows.Forms.Button();
            this.appraisalbtn = new System.Windows.Forms.Button();
            this.ManageUserMenuebtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.dashboardlabel = new System.Windows.Forms.Label();
            this.rbVacations = new HRManagementSystem.RoundButton();
            this.rbAppraisal = new HRManagementSystem.RoundButton();
            this.rbEmployees = new HRManagementSystem.RoundButton();
            this.rbMyProfile = new HRManagementSystem.RoundButton();
            this.rbDepartments = new HRManagementSystem.RoundButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(1, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(892, 42);
            this.textBox1.TabIndex = 0;
            // 
            // tbHeadings
            // 
            this.tbHeadings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbHeadings.Location = new System.Drawing.Point(1, 40);
            this.tbHeadings.Multiline = true;
            this.tbHeadings.Name = "tbHeadings";
            this.tbHeadings.Size = new System.Drawing.Size(214, 482);
            this.tbHeadings.TabIndex = 1;
            // 
            // hrms
            // 
            this.hrms.AutoSize = true;
            this.hrms.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hrms.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrms.ForeColor = System.Drawing.SystemColors.Info;
            this.hrms.Location = new System.Drawing.Point(51, 48);
            this.hrms.Name = "hrms";
            this.hrms.Size = new System.Drawing.Size(103, 41);
            this.hrms.TabIndex = 10;
            this.hrms.Text = "Menu";
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardbtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.dashboardbtn.Location = new System.Drawing.Point(44, 107);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(129, 39);
            this.dashboardbtn.TabIndex = 18;
            this.dashboardbtn.Text = "Dash Board";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            // 
            // departmentbtn
            // 
            this.departmentbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.departmentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.departmentbtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentbtn.ForeColor = System.Drawing.Color.White;
            this.departmentbtn.Location = new System.Drawing.Point(44, 317);
            this.departmentbtn.Name = "departmentbtn";
            this.departmentbtn.Size = new System.Drawing.Size(129, 39);
            this.departmentbtn.TabIndex = 20;
            this.departmentbtn.Text = "Departments";
            this.departmentbtn.UseVisualStyleBackColor = false;
            // 
            // employeebtn
            // 
            this.employeebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeebtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeebtn.ForeColor = System.Drawing.Color.White;
            this.employeebtn.Location = new System.Drawing.Point(44, 176);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(129, 39);
            this.employeebtn.TabIndex = 21;
            this.employeebtn.Text = "Employees";
            this.employeebtn.UseVisualStyleBackColor = false;
            this.employeebtn.Click += new System.EventHandler(this.empButton_Click);
            // 
            // Vacationbtn
            // 
            this.Vacationbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Vacationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vacationbtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vacationbtn.ForeColor = System.Drawing.Color.White;
            this.Vacationbtn.Location = new System.Drawing.Point(44, 389);
            this.Vacationbtn.Name = "Vacationbtn";
            this.Vacationbtn.Size = new System.Drawing.Size(129, 39);
            this.Vacationbtn.TabIndex = 22;
            this.Vacationbtn.Text = "Vacation";
            this.Vacationbtn.UseVisualStyleBackColor = false;
            // 
            // appraisalbtn
            // 
            this.appraisalbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.appraisalbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appraisalbtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appraisalbtn.ForeColor = System.Drawing.Color.White;
            this.appraisalbtn.Location = new System.Drawing.Point(44, 463);
            this.appraisalbtn.Name = "appraisalbtn";
            this.appraisalbtn.Size = new System.Drawing.Size(129, 39);
            this.appraisalbtn.TabIndex = 23;
            this.appraisalbtn.Text = "Appraisal";
            this.appraisalbtn.UseVisualStyleBackColor = false;
            // 
            // ManageUserMenuebtn
            // 
            this.ManageUserMenuebtn.BackColor = System.Drawing.Color.LightBlue;
            this.ManageUserMenuebtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUserMenuebtn.ForeColor = System.Drawing.Color.Black;
            this.ManageUserMenuebtn.Location = new System.Drawing.Point(751, 7);
            this.ManageUserMenuebtn.Name = "ManageUserMenuebtn";
            this.ManageUserMenuebtn.Size = new System.Drawing.Size(130, 28);
            this.ManageUserMenuebtn.TabIndex = 24;
            this.ManageUserMenuebtn.Text = "Manage User";
            this.ManageUserMenuebtn.UseVisualStyleBackColor = false;
            this.ManageUserMenuebtn.Click += new System.EventHandler(this.userButton_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.profilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilebtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.ForeColor = System.Drawing.Color.White;
            this.profilebtn.Location = new System.Drawing.Point(44, 251);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(129, 39);
            this.profilebtn.TabIndex = 27;
            this.profilebtn.Text = "My Profile";
            this.profilebtn.UseVisualStyleBackColor = false;
            // 
            // dashboardlabel
            // 
            this.dashboardlabel.AutoSize = true;
            this.dashboardlabel.BackColor = System.Drawing.Color.LightSlateGray;
            this.dashboardlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardlabel.Location = new System.Drawing.Point(358, 7);
            this.dashboardlabel.Name = "dashboardlabel";
            this.dashboardlabel.Size = new System.Drawing.Size(169, 32);
            this.dashboardlabel.TabIndex = 28;
            this.dashboardlabel.Text = "Dash Board";
            // 
            // rbVacations
            // 
            this.rbVacations.BackColor = System.Drawing.Color.GhostWhite;
            this.rbVacations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbVacations.BackgroundImage")));
            this.rbVacations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbVacations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVacations.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.rbVacations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbVacations.Location = new System.Drawing.Point(364, 389);
            this.rbVacations.Name = "rbVacations";
            this.rbVacations.Size = new System.Drawing.Size(113, 102);
            this.rbVacations.TabIndex = 17;
            this.rbVacations.UseVisualStyleBackColor = false;
            // 
            // rbAppraisal
            // 
            this.rbAppraisal.BackColor = System.Drawing.Color.GhostWhite;
            this.rbAppraisal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbAppraisal.BackgroundImage")));
            this.rbAppraisal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbAppraisal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAppraisal.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.rbAppraisal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAppraisal.Location = new System.Drawing.Point(592, 338);
            this.rbAppraisal.Name = "rbAppraisal";
            this.rbAppraisal.Size = new System.Drawing.Size(113, 102);
            this.rbAppraisal.TabIndex = 16;
            this.rbAppraisal.UseVisualStyleBackColor = false;
            // 
            // rbEmployees
            // 
            this.rbEmployees.BackColor = System.Drawing.Color.GhostWhite;
            this.rbEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbEmployees.BackgroundImage")));
            this.rbEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEmployees.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.rbEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmployees.Location = new System.Drawing.Point(659, 188);
            this.rbEmployees.Name = "rbEmployees";
            this.rbEmployees.Size = new System.Drawing.Size(113, 102);
            this.rbEmployees.TabIndex = 15;
            this.rbEmployees.UseVisualStyleBackColor = false;
            // 
            // rbMyProfile
            // 
            this.rbMyProfile.BackColor = System.Drawing.Color.GhostWhite;
            this.rbMyProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMyProfile.BackgroundImage")));
            this.rbMyProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMyProfile.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.rbMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMyProfile.Location = new System.Drawing.Point(285, 188);
            this.rbMyProfile.Name = "rbMyProfile";
            this.rbMyProfile.Size = new System.Drawing.Size(113, 102);
            this.rbMyProfile.TabIndex = 14;
            this.rbMyProfile.UseVisualStyleBackColor = false;
            // 
            // rbDepartments
            // 
            this.rbDepartments.BackColor = System.Drawing.Color.GhostWhite;
            this.rbDepartments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbDepartments.BackgroundImage")));
            this.rbDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDepartments.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.rbDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDepartments.Location = new System.Drawing.Point(467, 64);
            this.rbDepartments.Name = "rbDepartments";
            this.rbDepartments.Size = new System.Drawing.Size(113, 102);
            this.rbDepartments.TabIndex = 13;
            this.rbDepartments.UseVisualStyleBackColor = false;
            // 
            // Dash_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(893, 524);
            this.Controls.Add(this.dashboardlabel);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.ManageUserMenuebtn);
            this.Controls.Add(this.appraisalbtn);
            this.Controls.Add(this.Vacationbtn);
            this.Controls.Add(this.employeebtn);
            this.Controls.Add(this.departmentbtn);
            this.Controls.Add(this.dashboardbtn);
            this.Controls.Add(this.rbVacations);
            this.Controls.Add(this.rbAppraisal);
            this.Controls.Add(this.rbEmployees);
            this.Controls.Add(this.rbMyProfile);
            this.Controls.Add(this.rbDepartments);
            this.Controls.Add(this.hrms);
            this.Controls.Add(this.tbHeadings);
            this.Controls.Add(this.textBox1);
            this.IsMdiContainer = true;
            this.Name = "Dash_Board";
            this.Text = "Dash_Board";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dash_Board_FormClosing);
            this.Load += new System.EventHandler(this.Dash_Board_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbHeadings;
        private System.Windows.Forms.Label hrms;
        private RoundButton rbDepartments;
        private RoundButton rbMyProfile;
        private RoundButton rbEmployees;
        private RoundButton rbAppraisal;
        private RoundButton rbVacations;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Button departmentbtn;
        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.Button Vacationbtn;
        private System.Windows.Forms.Button appraisalbtn;
        private System.Windows.Forms.Button ManageUserMenuebtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Label dashboardlabel;
    }
}