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
    public partial class ManageUsers : Form
    {
        private readonly HRMSEntities2 _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new HRMSEntities2();
        }

        private void ManageUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
           if(!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();
            }

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                var hashed_password = Utils.DefaultHashedPassword();
                user.password = hashed_password;
                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s Password has been reset!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUserList.SelectedRows[0].Cells["id"].Value;
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                user.isActive = user.isActive == true ? false : true;
                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s Active Status has Changed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            
             var users = _db.Users
                 .Select(q => new
                    {
                        q.id,
                        q.username,
                        q.UserRoles.FirstOrDefault().Role.name,
                        q.isActive
                    })
                    .ToList();
             gvUserList.DataSource = users;
             gvUserList.Columns["username"].HeaderText = "Username";
             gvUserList.Columns["name"].HeaderText = "Role Name";
             gvUserList.Columns["isActive"].HeaderText = "Active";

             gvUserList.Columns["id"].Visible = false;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
