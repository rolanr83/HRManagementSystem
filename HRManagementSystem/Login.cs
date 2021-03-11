using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public partial class Login : Form
    {
        private readonly HRMSEntities2 _Db;

        public Login()
        {
            InitializeComponent();
            _Db = new HRMSEntities2();

        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();


                var user = _Db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_password);
                //&& q.isActive == true
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    var dashBoard = new Dash_Board(this);
                    dashBoard.Show();
                   Hide();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong. Please try again");

            }
        }
    }
}