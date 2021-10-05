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
            toolTip1.SetToolTip(LblInfo, "The Username should be at least eight characters long. \nUse atleast one upper and one lower case letters and one numbers.");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            LblTick.Text = "\u2713";
            LblTick.ForeColor = System.Drawing.Color.Green;

            LblTick.Text = "X";
            LblTick.ForeColor = System.Drawing.Color.Red;

        }
    }
}
