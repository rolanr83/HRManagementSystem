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
    public partial class Dash_Board : Form
    {
        private Login _login;
        public string _roleName;
        public User_Table _user;

        public Dash_Board(Login login, User_Table user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            //_roleName = user.UserRoles.FirstOrDefault().Role.shortname;

        }
    }
}
