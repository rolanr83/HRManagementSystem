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
    public partial class CreateUser : Form
    {
        private readonly HRMSEntities2 _db;
        private ManageEmployeeRecords _manageEmployeeListing;

        public bool isEditMode; /*{ get; set; }*/

        public CreateUser(ManageEmployeeRecords manageEmployeeListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Employee";
            this.Text = "Add New Employee";
            isEditMode = false;
            _manageEmployeeListing = manageEmployeeListing;
            _db = new HRMSEntities2();

        }

        public CreateUser(Employee staffToEdit, ManageEmployeeRecords manageEmployeeListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Employee";
            this.Text = "Edit Employee";
            _db = new HRMSEntities2();
            _manageEmployeeListing = manageEmployeeListing;
            if (staffToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new HRMSEntities2();
                PopulateFields(staffToEdit);
            }
            
        }

        private void PopulateFields(Employee staff)
        {
            lblId.Text = staff.StaffId.ToString();
            tbfname.Text = staff.First_Name;
            tbmname.Text = staff.Middle_Name;
            tblname.Text = staff.Last_Name;
            tbgender.Text = staff.Gender;
            tbtrn.Text = staff.TRN;
            tbnis.Text = staff.NIS;
            tbadd1.Text = staff.Address_1;
            tbadd2.Text = staff.Address_2;
            tbparish.Text = staff.Parish;
            tbpostalcode.Text = staff.Postal_Code;
            tbcountry.Text = staff.Country;
            dtdob.Value = staff.Date_Of_Birth ;
            tbms.Text = staff.Marital_Stuts;
            tbpnum.Text = staff.Home_Number;
            tbmnum.Text = staff.Mobile_Number;
            tbeadd.Text = staff.Email_Address;
            dtstartdate.Value = staff.Start_Date;
            dtenddate.Value = (DateTime)staff.End_Date;
            cbEmploymentStatus.Text = staff.Employment_Status;
            tbdepartment.Text = staff.Department;
            tbpost.Text = staff.Post;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = tbfname.Text;
                string MiddleName = tbmname.Text;
                string LastName = tblname.Text;
                string Gender = tbgender.Text;
                string TRN = tbtrn.Text;
                string NIS = tbnis.Text;
                string Address1 = tbadd1.Text;
                string Address2 = tbadd2.Text;
                string Parish = tbparish.Text;
                string PostalCode = tbpostalcode.Text;
                string Country = tbcountry.Text;
                var DOB = dtdob.Value;
                string MaritalStatus = tbms.Text;
                string HomeNumber = tbpnum.Text;
                string MobileNumber = tbmnum.Text;
                string EmailAddress = tbeadd.Text;
                var Startdate = dtstartdate.Value;
                var Enddate = dtenddate.Value;
                var TypeOfEmployement = cbEmploymentStatus.Text;
                string Department = tbdepartment.Text;
                string Post = tbpost.Text;


                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(MiddleName)
                    || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Gender)
                    || string.IsNullOrWhiteSpace(TRN) || string.IsNullOrWhiteSpace(NIS)
                    || string.IsNullOrWhiteSpace(Address1) || string.IsNullOrWhiteSpace(Address2)
                    || string.IsNullOrWhiteSpace(Parish) || string.IsNullOrWhiteSpace(Country)
                    || string.IsNullOrWhiteSpace(MobileNumber) || string.IsNullOrWhiteSpace(EmailAddress)
                    || string.IsNullOrWhiteSpace(TypeOfEmployement) || string.IsNullOrWhiteSpace(Department) 
                    || string.IsNullOrWhiteSpace(Post))
                {
                    isValid = false;
                    errorMessage += "Error: Please Enter Missing information. \n\r";
                }

                if (Startdate > Enddate)
                {
                    isValid = false;
                    errorMessage += "Error: Please Enter A Valid Date. \n\r";
                }
                if (isValid)
                {
                    if (isEditMode)
                    {
                        var id = int.Parse(lblId.Text);
                        var employee = _db.Employees.FirstOrDefault(q => q.StaffId == id);
                        employee.First_Name = tbfname.Text;
                        employee.Middle_Name = tbmname.Text;
                        employee.Last_Name = tblname.Text;
                        employee.Gender = tbgender.Text;
                        employee.TRN = tbtrn.Text;
                        employee.NIS = tbnis.Text;
                        employee.Address_1 = tbadd1.Text;
                        employee.Address_2 = tbadd2.Text;
                        employee.Parish = tbparish.Text;
                        employee.Postal_Code = tbpostalcode.Text;
                        employee.Country = tbcountry.Text;
                        employee.Date_Of_Birth = dtdob.Value;
                        employee.Marital_Stuts = tbms.Text;
                        employee.Home_Number = tbpnum.Text;
                        employee.Mobile_Number = tbmnum.Text;
                        employee.Email_Address = tbeadd.Text;
                        employee.Start_Date = dtstartdate.Value;
                        employee.End_Date = dtenddate.Value;
                        employee.Department = tbdepartment.Text;
                        employee.Post = tbpost.Text;
                        employee.EmploymentStatusid = (int)cbEmploymentStatus.SelectedValue; // comment out this line when you are ready to this



                    }

                    else
                    {
                        var newemployee = new Employee
                        {
                            First_Name = tbfname.Text,
                            Middle_Name = tbmname.Text,
                            Last_Name = tblname.Text,
                            Gender = tbgender.Text,
                            TRN = tbtrn.Text,
                            NIS = tbnis.Text,
                            Address_1 = tbadd1.Text,
                            Address_2 = tbadd2.Text,
                            Parish = tbparish.Text,
                            Postal_Code = tbpostalcode.Text,
                            Country = tbcountry.Text,
                            Date_Of_Birth = dtdob.Value,
                            Marital_Stuts = tbms.Text,
                            Mobile_Number = tbmnum.Text,
                            Email_Address = tbeadd.Text,
                            Start_Date = dtstartdate.Value,
                            End_Date = dtenddate.Value,
                            Department = tbdepartment.Text,
                            Post = tbpost.Text,
                            EmploymentStatusid = (int)cbEmploymentStatus.SelectedValue
                        };

                        _db.Employees.Add(newemployee);

                    }
                    _db.SaveChanges();
                    _manageEmployeeListing.PopulateGrid();
                    MessageBox.Show($"{FirstName} {LastName} Record Created ");
                    Close();

                }

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }      

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            var hrms = _db.EmploymentStatus.ToList();
            cbEmploymentStatus.DisplayMember = "Name";
            cbEmploymentStatus.ValueMember = "id";
            cbEmploymentStatus.DataSource = hrms;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
