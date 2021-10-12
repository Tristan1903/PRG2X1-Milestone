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
            DataHandler ATD = new DataHandler();
            string Modulecode;
            string ModuleName;
            string ModuleDescription;
            string ModuleLink;

            Modulecode = txtMID.Text;
            ModuleName = txtMName.Text;
            ModuleDescription = txtMdesc.Text;
            ModuleLink = txtMlink.Text;
            try
            {
                if (txtMID.Text == string.Empty || txtMName.Text == string.Empty || txtMdesc.Text == string.Empty || txtMlink.Text == string.Empty)
                {
                    throw new EmptyTextBoxException("Please Make sure all text boxes have values");
                }
                ATD.Add_Modules(Modulecode, ModuleName, ModuleDescription, ModuleLink);
            }
            catch (EmptyTextBoxException etb)
            {
                MessageBox.Show(etb.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to add Module : " + ex.Message);
            }
        }
    }
}
