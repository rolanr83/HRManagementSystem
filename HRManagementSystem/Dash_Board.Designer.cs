
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmanageusers = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appriasalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appraisalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.rbEmployees = new HRManagementSystem.RoundButton();
            this.rbMyProfile = new HRManagementSystem.RoundButton();
            this.rbDepartments = new HRManagementSystem.RoundButton();
            this.rbVacations = new HRManagementSystem.RoundButton();
            this.rbAppraisal = new HRManagementSystem.RoundButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(892, 94);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 15F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashBoardToolStripMenuItem,
            this.tsmanageusers,
            this.myProfileToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.vacationToolStripMenuItem,
            this.appriasalToolStripMenuItem,
            this.appraisalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(192, 524);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "Menu";
            // 
            // dashBoardToolStripMenuItem
            // 
            this.dashBoardToolStripMenuItem.Name = "dashBoardToolStripMenuItem";
            this.dashBoardToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.dashBoardToolStripMenuItem.Text = "Dash Board";
            // 
            // tsmanageusers
            // 
            this.tsmanageusers.Name = "tsmanageusers";
            this.tsmanageusers.Size = new System.Drawing.Size(179, 27);
            this.tsmanageusers.Text = "Manage Users";
            this.tsmanageusers.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.myProfileToolStripMenuItem.Text = "Manage Employee";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.departmentToolStripMenuItem.Text = "My Profile";
            // 
            // vacationToolStripMenuItem
            // 
            this.vacationToolStripMenuItem.Name = "vacationToolStripMenuItem";
            this.vacationToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.vacationToolStripMenuItem.Text = "Department";
            // 
            // appriasalToolStripMenuItem
            // 
            this.appriasalToolStripMenuItem.Name = "appriasalToolStripMenuItem";
            this.appriasalToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.appriasalToolStripMenuItem.Text = "Vacation";
            // 
            // appraisalToolStripMenuItem
            // 
            this.appraisalToolStripMenuItem.Name = "appraisalToolStripMenuItem";
            this.appraisalToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.appraisalToolStripMenuItem.Text = "Appraisal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Human Resource Management System";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(192, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // rbEmployees
            // 
            this.rbEmployees.BackColor = System.Drawing.Color.GhostWhite;
            this.rbEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbEmployees.BackgroundImage")));
            this.rbEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEmployees.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.rbEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmployees.Location = new System.Drawing.Point(661, 213);
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
            this.rbMyProfile.Location = new System.Drawing.Point(289, 213);
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
            this.rbDepartments.Location = new System.Drawing.Point(472, 100);
            this.rbDepartments.Name = "rbDepartments";
            this.rbDepartments.Size = new System.Drawing.Size(113, 102);
            this.rbDepartments.TabIndex = 13;
            this.rbDepartments.UseVisualStyleBackColor = false;
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
            // Dash_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(891, 524);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rbEmployees);
            this.Controls.Add(this.rbMyProfile);
            this.Controls.Add(this.rbDepartments);
            this.Controls.Add(this.textBox1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dash_Board";
            this.Text = "Dash_Board";
            this.Load += new System.EventHandler(this.Dash_Board_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private RoundButton rbDepartments;
        private RoundButton rbMyProfile;
        private RoundButton rbEmployees;
        private RoundButton rbAppraisal;
        private RoundButton rbVacations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmanageusers;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appriasalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appraisalToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}