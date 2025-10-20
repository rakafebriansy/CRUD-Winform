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

            Dashboard dashboard = new Dashboard(Username,Password);
            this.Hide();
            dashboard.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblregister_Click(object sender, EventArgs e)
        {
           
        }
    }
}
