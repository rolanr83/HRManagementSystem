﻿
namespace HRManagementSystem
{
    partial class ManageEmployeeListing
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
            this.label1 = new System.Windows.Forms.Label();
            this.gvManageemployeeList = new System.Windows.Forms.DataGridView();
            this.DeleteEmployeebtn = new System.Windows.Forms.Button();
            this.EditEmployeebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvManageemployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Employee List ";
            // 
            // gvManageemployeeList
            // 
            this.gvManageemployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManageemployeeList.Location = new System.Drawing.Point(25, 114);
            this.gvManageemployeeList.Name = "gvManageemployeeList";
            this.gvManageemployeeList.Size = new System.Drawing.Size(1015, 288);
            this.gvManageemployeeList.TabIndex = 1;
            // 
            // DeleteEmployeebtn
            // 
            this.DeleteEmployeebtn.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployeebtn.Location = new System.Drawing.Point(790, 437);
            this.DeleteEmployeebtn.Name = "DeleteEmployeebtn";
            this.DeleteEmployeebtn.Size = new System.Drawing.Size(130, 43);
            this.DeleteEmployeebtn.TabIndex = 4;
            this.DeleteEmployeebtn.Text = "Delete";
            this.DeleteEmployeebtn.UseVisualStyleBackColor = true;
            // 
            // EditEmployeebtn
            // 
            this.EditEmployeebtn.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployeebtn.Location = new System.Drawing.Point(142, 437);
            this.EditEmployeebtn.Name = "EditEmployeebtn";
            this.EditEmployeebtn.Size = new System.Drawing.Size(107, 43);
            this.EditEmployeebtn.TabIndex = 3;
            this.EditEmployeebtn.Text = "Edit";
            this.EditEmployeebtn.UseVisualStyleBackColor = true;
            // 
            // ManageEmployeeListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 492);
            this.Controls.Add(this.DeleteEmployeebtn);
            this.Controls.Add(this.EditEmployeebtn);
            this.Controls.Add(this.gvManageemployeeList);
            this.Controls.Add(this.label1);
            this.Name = "ManageEmployeeListing";
            this.Text = "Manage Employee Listing";
            this.Load += new System.EventHandler(this.ManageEmployeeListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvManageemployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvManageemployeeList;
        private System.Windows.Forms.Button DeleteEmployeebtn;
        private System.Windows.Forms.Button EditEmployeebtn;
    }
}