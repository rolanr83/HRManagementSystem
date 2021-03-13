
namespace HRManagementSystem
{
    partial class EmployeeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageEmployeeRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeRecordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageEmployeeRecordsToolStripMenuItem
            // 
            this.manageEmployeeRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.editEmployeeRecordsToolStripMenuItem,
            this.viewEmployeeRecordsToolStripMenuItem,
            this.viewArchiveToolStripMenuItem});
            this.manageEmployeeRecordsToolStripMenuItem.Name = "manageEmployeeRecordsToolStripMenuItem";
            this.manageEmployeeRecordsToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.manageEmployeeRecordsToolStripMenuItem.Text = "Manage Employee Records";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeRecordsToolStripMenuItem
            // 
            this.editEmployeeRecordsToolStripMenuItem.Name = "editEmployeeRecordsToolStripMenuItem";
            this.editEmployeeRecordsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editEmployeeRecordsToolStripMenuItem.Text = "Edit Employee Records";
            // 
            // viewEmployeeRecordsToolStripMenuItem
            // 
            this.viewEmployeeRecordsToolStripMenuItem.Name = "viewEmployeeRecordsToolStripMenuItem";
            this.viewEmployeeRecordsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewEmployeeRecordsToolStripMenuItem.Text = "View Employee Records";
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeForm";
            this.Text = "Human Resource Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
    }
}