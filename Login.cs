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
        public Login()
        {
            InitializeComponent();
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            txtLGPass.PasswordChar = '\0';
        }
    }
}
