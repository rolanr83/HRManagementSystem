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
        public CreateUser()
        {
            InitializeComponent();
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
                //string DOB = dtdob.Text;
                string MaritalStatus = tbms.Text;
                string MobileNumber = tbmnum.Text;
                string EmailAddress = tbeadd.Text;
                var Startdate = dtstartdate.Value;
                var Enddate = dtenddate.Value;
                var TypeOfEmployement = tbtoe.Text;
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
                    /*||string.IsNullOrWhiteSpace(DOB)*/ || string.IsNullOrWhiteSpace(TypeOfEmployement)
                    || string.IsNullOrWhiteSpace(Department) || string.IsNullOrWhiteSpace(Post))
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
                    

        }
    }
}
