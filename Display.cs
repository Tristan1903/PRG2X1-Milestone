using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRG2X1_Milestone
{
    public partial class Display : Form
    {
        
        public Display()
        {
            InitializeComponent();
            
        }

        DataHandler handlerobj = new DataHandler();
        private void btnStudents_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = handlerobj.DisplayStudents();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load Students : " + ex.Message);
            }
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = handlerobj.DisplayModules();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Modules : " + ex.Message);
            }
        }
    }
}
