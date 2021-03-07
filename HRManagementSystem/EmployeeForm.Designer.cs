
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
            this.nelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nelabel
            // 
            this.nelabel.AutoSize = true;
            this.nelabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nelabel.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nelabel.Location = new System.Drawing.Point(191, 9);
            this.nelabel.Name = "nelabel";
            this.nelabel.Size = new System.Drawing.Size(343, 42);
            this.nelabel.TabIndex = 22;
            this.nelabel.Text = "View Employee\'s ";
            this.nelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nelabel);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nelabel;
    }
}