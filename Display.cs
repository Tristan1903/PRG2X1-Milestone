using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;


namespace PRG2X1_Milestone
{
    public partial class Display : Form
    {
        
        public Display()
        {
            InitializeComponent();
        
        }


        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string search;
            string connectStr = "server=.;Initial Catalog=PRG2X1_Milestone_DB;Integrated Security=SSPI";
            SqlConnection con;

            search = Interaction.InputBox("Delete", "Search numebr to delete", " ");
            
            try
            {
                using (con = new SqlConnection(connectStr));
                String query = "DELETE FROM Student WHERE StudentID = @number";
                
                    con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@number", search);
                    command.ExecuteNonQuery();
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Failed" + error.Message);

            }
            
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
