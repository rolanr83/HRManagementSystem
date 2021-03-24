using Microsoft.VisualBasic.CompilerServices;
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
    public partial class DashBoard : Form
    {
        private Login _login;
        public string _roleName;
        public User _user;


        public DashBoard()
        {
            InitializeComponent();
           
        }

        public DashBoard(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.shortname;
        }      
       
        private void Dash_Board_Load(object sender, EventArgs e)
        {
            if (_user.password == Utils.DefaultHashedPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }

            var username = _user.username;
            tsiLoggingText.Text = $"Logged in As: {username}";
            if (_roleName != "admin")
            {
                tsmanageusers.Visible = false;
            }
        }

        private void tsmanageusers_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageUsers");
            if (!isOpen)
            {
                var manageUsers = new ManageUsers();
                manageUsers.ShowDialog();
                manageUsers.MdiParent = this;
            }
        }

        private void myProfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == "ManageEmployeeListing");
            if (!isOpen)
            {
                var emploeelisting = new ManageEmployeeRecords();
                emploeelisting.ShowDialog();
                emploeelisting.MdiParent = this;
            }
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
