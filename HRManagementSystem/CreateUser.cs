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
        private readonly HRMSEntities2 hRMSEntities2;

        public bool IsEditMode { get; set; }

        public CreateUser()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Employee";
            IsEditMode = false;
            hRMSEntities2 = new HRMSEntities2();

        }

        public CreateUser(Employee staffToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Employee";
            hRMSEntities2 = new HRMSEntities2();
            IsEditMode = true;
            PopulateFields(staffToEdit);
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
                //MessageBox.Show($"{tbfname.Text} {tblname.Text} Record Created ");
                //OR
                string FirstName = tbfname.Text;
                string MiddleName = tbmname.Text;
                string LastName = tblname.Text;
                string Gender = tbgender.Text;
                string TRN = tbtrn.Text;
                string NIS = tbnis.Text;
                string Address1 = tbadd1.Text;
                string Address2 = tbadd2.Text;
                string Parish = tbparish.Text;
                string Country = tbcountry.Text;
                var DOB = dtdob.Value;
                string MaritalStatus = tbms.Text;
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
                //if(isValid == true)
                if (isValid)
                {
                    var employee = new Employee();
                    employee.First_Name = FirstName;
                    employee.Middle_Name = MiddleName;
                    employee.Last_Name = LastName;
                    employee.Gender = Gender;
                    employee.TRN = TRN;
                    employee.NIS = NIS;
                    employee.Address_1 = Address1;
                    employee.Address_2 = Address2;
                    employee.Parish = Parish;
                    employee.Country = Country;
                    employee.Date_Of_Birth = DOB;
                    employee.Marital_Stuts = MaritalStatus;
                    employee.Mobile_Number = MobileNumber;
                    employee.Email_Address = EmailAddress;
                    employee.Start_Date = Startdate;
                    employee.End_Date = Enddate;
                    employee.Department = Department;
                    employee.Post = Post;
                    employee.EmploymentStatusid = (int)cbEmploymentStatus.SelectedValue;

                    hRMSEntities2.Employees.Add(employee);
                    hRMSEntities2.SaveChanges();




                    MessageBox.Show($"{FirstName} {LastName} Record Created ");
                }

                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

            if(IsEditMode)
            {
                var id = int.Parse(lblId.Text);
                var employee = hRMSEntities2.Employees.FirstOrDefault(q => q.StaffId == id);
                employee.First_Name = tbfname.Text;
                employee.Middle_Name = tbmname.Text;
                employee.Last_Name = tblname.Text;
                employee.Gender = tbgender.Text;
                employee.TRN = tbtrn.Text;
                employee.NIS = tbnis.Text;
                employee.Address_1 = tbadd1.Text;
                employee.Address_2 = tbadd2.Text;
                employee.Parish = tbparish.Text;
                employee.Country = tbcountry.Text;
                employee.Date_Of_Birth = dtdob.Value;
                employee.Marital_Stuts = tbms.Text;
                employee.Mobile_Number = tbmnum.Text;
                employee.Email_Address = tbeadd.Text;
                employee.Start_Date = dtstartdate.Value;
                employee.End_Date = dtenddate.Value;
                employee.Department = tbdepartment.Text;
                employee.Post = tbpost.Text;
                employee.EmploymentStatusid = (int)cbEmploymentStatus.SelectedValue;

                hRMSEntities2.SaveChanges();
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

                hRMSEntities2.SaveChanges();
            }
                    

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            var hrms = hRMSEntities2.EmploymentStatus.ToList();
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
