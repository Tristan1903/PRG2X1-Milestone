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
        string connectStr = "server=.;Initial Catalog=NORTHWND;Integrated Security=SSPI";
        SqlConnection con;
        public Display()
        {
            InitializeComponent();
            con = new SqlConnection(connectStr);
        }

        DataHandler handlerobj = new DataHandler();
        private void btnStudents_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Categories", con);
            SqlDataReader wow = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = wow;
            dataGridView1.DataSource = source;
            con.Close();
            //dataGridView1.DataSource = handlerobj.getStudents();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handlerobj.getModules();
        }
    }
}
