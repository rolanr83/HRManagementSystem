
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
            this.dbButton = new System.Windows.Forms.Button();
            this.proButton = new System.Windows.Forms.Button();
            this.deptButton = new System.Windows.Forms.Button();
            this.empButton = new System.Windows.Forms.Button();
            this.VacButton = new System.Windows.Forms.Button();
            this.appButton = new System.Windows.Forms.Button();
            this.rbVacations = new HRManagementSystem.RoundButton();
            this.rbAppraisal = new HRManagementSystem.RoundButton();
            this.rbEmployees = new HRManagementSystem.RoundButton();
            this.rbMyProfile = new HRManagementSystem.RoundButton();
            this.rbDepartments = new HRManagementSystem.RoundButton();
            this.userButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(1, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(875, 42);
            this.textBox1.TabIndex = 0;
            // 
            // tbHeadings
            // 
            this.tbHeadings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbHeadings.Location = new System.Drawing.Point(1, 40);
            this.tbHeadings.Multiline = true;
            this.tbHeadings.Name = "tbHeadings";
            this.tbHeadings.Size = new System.Drawing.Size(213, 409);
            this.tbHeadings.TabIndex = 1;
            // 
            // hrms
            // 
            this.hrms.AutoSize = true;
            this.hrms.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hrms.Font = new System.Drawing.Font("Lucida Sans Unicode", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrms.ForeColor = System.Drawing.SystemColors.Info;
            this.hrms.Location = new System.Drawing.Point(51, 42);
            this.hrms.Name = "hrms";
            this.hrms.Size = new System.Drawing.Size(94, 34);
            this.hrms.TabIndex = 10;
            this.hrms.Text = "HRMS";
            // 
            // dbButton
            // 
            this.dbButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dbButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbButton.ForeColor = System.Drawing.Color.White;
            this.dbButton.Location = new System.Drawing.Point(34, 105);
            this.dbButton.Name = "dbButton";
            this.dbButton.Size = new System.Drawing.Size(129, 39);
            this.dbButton.TabIndex = 18;
            this.dbButton.Text = "Dash Board";
            this.dbButton.UseVisualStyleBackColor = false;
            this.dbButton.Click += new System.EventHandler(this.dbButton_Click);
            // 
            // proButton
            // 
            this.proButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.proButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proButton.ForeColor = System.Drawing.Color.White;
            this.proButton.Location = new System.Drawing.Point(34, 165);
            this.proButton.Name = "proButton";
            this.proButton.Size = new System.Drawing.Size(129, 39);
            this.proButton.TabIndex = 19;
            this.proButton.Text = "My Profile";
            this.proButton.UseVisualStyleBackColor = false;
            this.proButton.Click += new System.EventHandler(this.proButton_Click);
            // 
            // deptButton
            // 
            this.deptButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.deptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deptButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptButton.ForeColor = System.Drawing.Color.White;
            this.deptButton.Location = new System.Drawing.Point(34, 226);
            this.deptButton.Name = "deptButton";
            this.deptButton.Size = new System.Drawing.Size(129, 39);
            this.deptButton.TabIndex = 20;
            this.deptButton.Text = "Departments";
            this.deptButton.UseVisualStyleBackColor = false;
            this.deptButton.Click += new System.EventHandler(this.deptButton_Click);
            // 
            // empButton
            // 
            this.empButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.empButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empButton.ForeColor = System.Drawing.Color.White;
            this.empButton.Location = new System.Drawing.Point(34, 283);
            this.empButton.Name = "empButton";
            this.empButton.Size = new System.Drawing.Size(129, 39);
            this.empButton.TabIndex = 21;
            this.empButton.Text = "Employees";
            this.empButton.UseVisualStyleBackColor = false;
            this.empButton.Click += new System.EventHandler(this.empButton_Click);
            // 
            // VacButton
            // 
            this.VacButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.VacButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VacButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VacButton.ForeColor = System.Drawing.Color.White;
            this.VacButton.Location = new System.Drawing.Point(34, 342);
            this.VacButton.Name = "VacButton";
            this.VacButton.Size = new System.Drawing.Size(129, 39);
            this.VacButton.TabIndex = 22;
            this.VacButton.Text = "Vacation";
            this.VacButton.UseVisualStyleBackColor = false;
            // 
            // appButton
            // 
            this.appButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.appButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appButton.ForeColor = System.Drawing.Color.White;
            this.appButton.Location = new System.Drawing.Point(34, 397);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(129, 39);
            this.appButton.TabIndex = 23;
            this.appButton.Text = "Appraisal";
            this.appButton.UseVisualStyleBackColor = false;
            // 
            // rbVacations
            // 
            this.rbVacations.BackColor = System.Drawing.Color.GhostWhite;
            this.rbVacations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbVacations.BackgroundImage")));
            this.rbVacations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbVacations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVacations.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.rbVacations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbVacations.Location = new System.Drawing.Point(362, 326);
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
            this.rbAppraisal.Location = new System.Drawing.Point(573, 326);
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
            this.rbEmployees.Location = new System.Drawing.Point(621, 176);
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
            this.rbMyProfile.Location = new System.Drawing.Point(286, 176);
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
            this.rbDepartments.Location = new System.Drawing.Point(447, 90);
            this.rbDepartments.Name = "rbDepartments";
            this.rbDepartments.Size = new System.Drawing.Size(113, 102);
            this.rbDepartments.TabIndex = 13;
            this.rbDepartments.UseVisualStyleBackColor = false;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.LightBlue;
            this.userButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.Color.Black;
            this.userButton.Location = new System.Drawing.Point(746, 48);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(130, 28);
            this.userButton.TabIndex = 24;
            this.userButton.Text = "Manage User";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(758, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Howdy, Admin";
            // 
            // Dash_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(876, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.appButton);
            this.Controls.Add(this.VacButton);
            this.Controls.Add(this.empButton);
            this.Controls.Add(this.deptButton);
            this.Controls.Add(this.proButton);
            this.Controls.Add(this.dbButton);
            this.Controls.Add(this.rbVacations);
            this.Controls.Add(this.rbAppraisal);
            this.Controls.Add(this.rbEmployees);
            this.Controls.Add(this.rbMyProfile);
            this.Controls.Add(this.rbDepartments);
            this.Controls.Add(this.hrms);
            this.Controls.Add(this.tbHeadings);
            this.Controls.Add(this.textBox1);
            this.Name = "Dash_Board";
            this.Text = "Dash_Board";
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
        private System.Windows.Forms.Button dbButton;
        private System.Windows.Forms.Button proButton;
        private System.Windows.Forms.Button deptButton;
        private System.Windows.Forms.Button empButton;
        private System.Windows.Forms.Button VacButton;
        private System.Windows.Forms.Button appButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Label label1;
    }
}