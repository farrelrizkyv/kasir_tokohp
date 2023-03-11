using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokohp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == "admin" && password == "parel")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Hide();
                // Jika login sukses, lakukan sesuatu di sini
            }
            else
            {
                // Jika login gagal, tampilkan pesan kesalahan
                //errorLabel.Text = "Username atau password salah";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
