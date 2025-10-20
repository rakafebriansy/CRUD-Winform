using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Winform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = TBUsername.Text;
            string Password = TBPassword.Text;
            if (Username == User.Username && Password == User.Password)
            {
                Dashboard dashboard = new Dashboard(Username, Password);
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Password dan Username Tidak Sesuai", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void lblregister_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
