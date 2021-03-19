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
        public string _RoleName;
        public ManageUsers _manageUsers;
        

        public Dash_Board()
        {
            InitializeComponent();
           
        }

        public Dash_Board(Login login, string roleShortName)
        {
            InitializeComponent();
            _login = login;
            _RoleName = roleShortName;
            //_roleName = user.UserRoles.FirstOrDefault().Role.shortname;
        }      
       
        private void Dash_Board_Load(object sender, EventArgs e)
        {
            if(_RoleName != "admin")
            {
                tsmanageusers.Visible = false;

            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
            manageUsers.MdiParent = this;
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeFrom = new ManageEmployeeRecords();
            employeeFrom.ShowDialog();
            MdiParent = MdiParent;
        }
    }
}
