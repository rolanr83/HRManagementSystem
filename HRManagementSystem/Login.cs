﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public partial class Login : Form
    {
        private readonly HRMSEntities2 _Db;

        public Login()
        {
            InitializeComponent();
            _Db = new HRMSEntities2();

        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                var hashed_password = Utils.HashPassword(password);


                var user = _Db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_password
                            && q.isActive == true);
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleShortName = role.Role.shortname;
                    var dashBoard = new DashBoard(this, user);
                    dashBoard.Show();
                    Hide();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong. Please try again");

            }
        }
    }
}