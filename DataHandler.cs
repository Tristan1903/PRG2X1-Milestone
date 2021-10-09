using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2X1_Milestone
{
    class DataHandler
    {
        string connectStr = "server=.;Initial Catalog=PRG2X1_Milestone_DB;Integrated Security=SSPI";
        public DataHandler() { }

        public DataTable DisplayData(string query)
        { 
            SqlDataAdapter datadapt = new SqlDataAdapter(query, connectStr);
            DataTable datatabl = new DataTable();
            datadapt.Fill(datatabl);
            return datatabl;
        }

        public void UpdateData(string query)
        {
            SqlConnection connect = new SqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand(query,connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
