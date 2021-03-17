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
    public partial class ManageEmployeeRecords : Form
    {
        public ManageEmployeeRecords()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createuser = new CreateUser();
            createuser.MdiParent = this;
            createuser.Show();         
        }


        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
               var emploeelisting = new ManageEmployeeListing();
               emploeelisting.MdiParent = this;
               emploeelisting.Show();
        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}