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
    public partial class ManageEmployeeListing : Form
    {
        private readonly HRMSEntities2 _db;
        public ManageEmployeeListing()
        {
            InitializeComponent();
            _db = new HRMSEntities2();
        }

        private void ManageEmployeeListing_Load(object sender, EventArgs e)
        {
            //var employees = _db.Employees.ToList();
            var employees = _db.Employees.Select(q => new
            {
                STAFF_ID = q.StaffId,
                First_Name = q.First_Name,
                Middle_Name = q.Middle_Name,
                Last_Name = q.Last_Name,
                Date_Of_Birth = q.Date_Of_Birth,
                TRN = q.TRN,
                NIS = q.NIS,
                Marital_Stuts = q.Marital_Stuts,
                Address_1 = q.Address_1,
                Address_2 = q.Address_2,
                Parish = q.Parish,
                Postal_code = q.Postal_Code,
                Country = q.Country,
                Home_Number = q.Home_Number,
                Mobile_Number = q.Mobile_Number,
                Email_Address = q.Email_Address,
                Department = q.Department,
                Post = q.Post,
                Employment_Status = q.Employment_Status,
                Start_date = q.Start_Date,
                End_date = q.End_Date
            })
            .ToList();

            gvManageemployeeList.DataSource = employees;
            gvManageemployeeList.Columns[0].Visible = false;
            gvManageemployeeList.Columns[1].HeaderText = "First Name";
            gvManageemployeeList.Columns[2].HeaderText = "Middle Name";
            gvManageemployeeList.Columns[3].HeaderText = "Last Name";
            gvManageemployeeList.Columns[4].HeaderText = "Date Of Birth";
            gvManageemployeeList.Columns[7].HeaderText = "Marital Status";
            gvManageemployeeList.Columns[8].HeaderText = "Address 1";
            gvManageemployeeList.Columns[9].HeaderText = "Address 2";
            gvManageemployeeList.Columns[11].HeaderText = "P.O. Box";
            gvManageemployeeList.Columns[13].HeaderText = "Home Number";
            gvManageemployeeList.Columns[14].HeaderText = "Mobile Number";
            gvManageemployeeList.Columns[15].HeaderText = "Email Address";
            gvManageemployeeList.Columns[18].HeaderText = "Employment Status";
            gvManageemployeeList.Columns[19].HeaderText = "Start Date";
            gvManageemployeeList.Columns[20].HeaderText = "End Date";           
        }

    }
}
