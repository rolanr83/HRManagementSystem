
namespace HRManagementSystem
{
    partial class ResetPassword
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
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbconfirmpassword = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(81, 22);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(155, 23);
            this.btnNewUser.TabIndex = 2;
            this.btnNewUser.Text = "Enter New Password";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.Location = new System.Drawing.Point(81, 137);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(155, 23);
            this.btnConfirmPassword.TabIndex = 3;
            this.btnConfirmPassword.Text = "Confirm Password";
            this.btnConfirmPassword.UseVisualStyleBackColor = true;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(57, 60);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(197, 20);
            this.tbpassword.TabIndex = 4;
            // 
            // tbconfirmpassword
            // 
            this.tbconfirmpassword.Location = new System.Drawing.Point(57, 177);
            this.tbconfirmpassword.Name = "tbconfirmpassword";
            this.tbconfirmpassword.PasswordChar = '*';
            this.tbconfirmpassword.Size = new System.Drawing.Size(197, 20);
            this.tbconfirmpassword.TabIndex = 5;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(81, 227);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(155, 46);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 285);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.tbconfirmpassword);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.btnConfirmPassword);
            this.Controls.Add(this.btnNewUser);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnConfirmPassword;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbconfirmpassword;
        private System.Windows.Forms.Button btnResetPassword;
    }
}