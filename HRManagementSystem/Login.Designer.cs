
namespace HRManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.unlabel = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pwlabel = new System.Windows.Forms.Label();
            this.wellabel = new System.Windows.Forms.Label();
            this.signlabel = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(281, 249);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(248, 26);
            this.tbPassword.TabIndex = 3;
            // 
            // unlabel
            // 
            this.unlabel.AutoSize = true;
            this.unlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlabel.Location = new System.Drawing.Point(124, 194);
            this.unlabel.Name = "unlabel";
            this.unlabel.Size = new System.Drawing.Size(70, 19);
            this.unlabel.TabIndex = 4;
            this.unlabel.Text = "Username";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(281, 194);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(248, 29);
            this.tbUserName.TabIndex = 2;
            // 
            // pwlabel
            // 
            this.pwlabel.AutoSize = true;
            this.pwlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwlabel.Location = new System.Drawing.Point(124, 252);
            this.pwlabel.Name = "pwlabel";
            this.pwlabel.Size = new System.Drawing.Size(69, 19);
            this.pwlabel.TabIndex = 5;
            this.pwlabel.Text = "Password";
            // 
            // wellabel
            // 
            this.wellabel.AutoSize = true;
            this.wellabel.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wellabel.Location = new System.Drawing.Point(339, 68);
            this.wellabel.Name = "wellabel";
            this.wellabel.Size = new System.Drawing.Size(121, 34);
            this.wellabel.TabIndex = 7;
            this.wellabel.Text = "Welcome";
            // 
            // signlabel
            // 
            this.signlabel.AutoSize = true;
            this.signlabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signlabel.Location = new System.Drawing.Point(316, 125);
            this.signlabel.Name = "signlabel";
            this.signlabel.Size = new System.Drawing.Size(174, 22);
            this.signlabel.TabIndex = 8;
            this.signlabel.Text = "Please sign in below";
            // 
            // btnlogin
            // 
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(365, 336);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(95, 34);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.signlabel);
            this.Controls.Add(this.wellabel);
            this.Controls.Add(this.pwlabel);
            this.Controls.Add(this.unlabel);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label unlabel;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label pwlabel;
        private System.Windows.Forms.Label wellabel;
        private System.Windows.Forms.Label signlabel;
        private System.Windows.Forms.Button btnlogin;
    }
}