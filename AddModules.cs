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
    public partial class AddModules : Form
    {
        public AddModules()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToDatabase ATD = new AddToDatabase();
            string Modulecode;
            string ModuleName;
            string ModuleDescription;
            string ModuleLink;

            Modulecode = txtMID.Text;
            ModuleName = txtMName.Text;
            ModuleDescription = txtMdesc.Text;
            ModuleLink = txtMlink.Text;

            ATD.Add_Modules(Modulecode, ModuleName, ModuleDescription, ModuleLink);

        }
    }
}
