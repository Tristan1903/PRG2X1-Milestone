using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PRG2X1_Milestone
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(LblInfo, "The Username should be between eight and twenty characters long. \nMay only contain letters and numbers");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (txtPass1.Text == txtPass2.Text)
            {
                LblTick.Text = "\u2713";
                LblTick.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LblTick.Text = "X";
                LblTick.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File_Handler User_Creation = new File_Handler();
            string Username;
            string Password_Main;
            bool exsist;

            Username = txtUser.Text;
            exsist = User_Creation.User_Exsistance(Username);
            if (Validate() == false)
            {
                MessageBox.Show("Invalid Username");
            }
            else if (exsist == true)
            {
                MessageBox.Show("Username already exsits");
                txtUser.Text = "";
                txtPass1.Text = "";
                txtPass2.Text = "";
            }
            else
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    Password_Main = txtPass1.Text;
                    User_Creation.Set_Values(Username, Password_Main);

                    try
                    {
                        User_Creation.Registration_Writer();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed" + ex.Message);
                    }
                    
                    Switch_To_Login();
                }
                else
                {
                    MessageBox.Show("Passwords do not match");

                    txtUser.Text = "";
                    txtPass1.Text = "";
                    txtPass2.Text = "";
                }
            }
        }

        public bool Validate_User_Input()
        {
            bool entry;
            Regex check = new Regex("^[a-z A-Z 0-9]*$");

            if (check.IsMatch(txtUser.Text) == true)
            {
                entry = true;
            }
            else
            {
                entry = false;
            }

            return entry;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Switch_To_Login();
        }

        private void Switch_To_Login()
        {
            Login Move_To_Login = new Login();
            this.Hide();
            Move_To_Login.Show();
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "Show")
            {
                txtPass1.PasswordChar = '\0';
                txtPass2.PasswordChar = '\0';
                lblShow.Text = "Hide";
            }
            else if (lblShow.Text == "Hide")
            {
                txtPass1.PasswordChar = '*';
                txtPass2.PasswordChar = '*';
                lblShow.Text = "Show";
            }

        }
    }
}
