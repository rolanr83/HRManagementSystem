﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public partial class Dash_Board : Form
    {
        private Login _login;
        public ManageUsers _manageUsers;
        //public string _roleName;
        //public User _user;

        public Dash_Board()
        {
            InitializeComponent();
           
        }

        public Dash_Board(Login login)
        {
            InitializeComponent();
            _login = login;
            //_user = user;
            //_roleName = user.UserRoles.FirstOrDefault().Role.shortname;
        }

        public Dash_Board(ManageUsers manageUsers)
        {
            InitializeComponent();
            _manageUsers = manageUsers;
        }
        private void dbButton_Click(object sender, EventArgs e)
        {

        }

        private void proButton_Click(object sender, EventArgs e)
        {

        }

        private void deptButton_Click(object sender, EventArgs e)
        {

        }

        private void empButton_Click(object sender, EventArgs e)
        {
            var employeeFrom = new EmployeeForm ();
                employeeFrom.Show();
            //Hide();
            

        }

        private void userButton_Click(object sender, EventArgs e)
        {
            //if (!Utils.FormIsOpen(""))
           // {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
                //Hide();
            //}
        }

        private void Dash_Board_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
