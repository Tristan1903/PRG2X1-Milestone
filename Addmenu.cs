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
    public partial class Addmenu : Form
    {
        public Addmenu()
        {
            InitializeComponent();
        }

        private void btnAModules_Click(object sender, EventArgs e)
        {
            AddModules add_modules = new AddModules();
            this.Hide();
            add_modules.Show();

        }

        private void btnAStudents_Click(object sender, EventArgs e)
        {
            AddStudents add_students = new AddStudents();
            this.Hide();
            add_students.Show();
        }
    }
}
