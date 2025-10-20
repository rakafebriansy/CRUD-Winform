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
    public partial class Form1 : Form
    {
        private String _Username;
        private String _Password;
        private String _ConfirmPassword;
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _Username = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_Password != _ConfirmPassword)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User.Username = _Username;
            User.Password = _Password;

            MessageBox.Show("Registrasi Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _Password = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _ConfirmPassword = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
