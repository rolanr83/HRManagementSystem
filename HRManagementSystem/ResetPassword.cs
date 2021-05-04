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
    public partial class ResetPassword : Form
    {
        private readonly HRMSEntities2 _db;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            _db = new HRMSEntities2();
            _user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tbpassword.Text;
                var confirm_password = tbconfirmpassword.Text;
                var user = _db.Users.FirstOrDefault(q => q.id == _user.id);
                if (password != confirm_password)
                {
                    MessageBox.Show("Password do not match. Please try again!");
                }

                _user.password = Utils.HashPassword(password);
                _db.SaveChanges();
                MessageBox.Show("Password was Reset Successfully");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" An Error has occured. Please try again");
            }
        }
    }
}
