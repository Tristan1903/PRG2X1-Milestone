using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2X1_Milestone
{
    public partial class Login : Form
    {

        User_Loging_Handler login_process = new User_Loging_Handler();
        Display success = new Display();

        public Login()
        {
            InitializeComponent();
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            txtLGPass.PasswordChar = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entered_username;
            string entered_password;
            bool logged;

            entered_username = txtLogUs.Text;
            entered_password = txtLGPass.Text;

            logged = login_process.Logining_in(entered_username,entered_password);

            if (logged == true)
            {
                MessageBox.Show("User logged in succesfully");
                this.Hide();
                success.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                txtLogUs.Text = "";
                txtLGPass.Text = "";                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Switch_To_Register();
        }

        public void Switch_To_Register()
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }
    }
}
