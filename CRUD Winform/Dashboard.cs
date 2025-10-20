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
    public partial class Dashboard : Form
    {
        private string _username;
        private string _password;
        public Dashboard(string username, string password)
        {
            this._username = username;
            this._password = password;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblSlmtDtng.Text = $"Selamat datang {this._username}";
        }
    }
}
