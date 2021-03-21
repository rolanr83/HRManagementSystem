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
        public ManageUsers _manageUsers;
        public User user;
        

        public DashBoard()
        {
            InitializeComponent();
           
        }

        public DashBoard(Login login, string roleShortName)
        {
            InitializeComponent();
            _login = login;
            _roleName = roleShortName;
            _roleName = user.UserRoles.FirstOrDefault().Role.shortname;
        }      
       
        private void Dash_Board_Load(object sender, EventArgs e)
        {
            if(_roleName != "admin")
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
    }
}
