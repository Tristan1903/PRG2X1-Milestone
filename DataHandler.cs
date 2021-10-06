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

        public DataTable getStudents()
        {
            string query = @"SELECT * FROM Student";
            SqlDataAdapter datadapt = new SqlDataAdapter(query, connectStr);
            DataTable datatabl = new DataTable();
            datadapt.Fill(datatabl);
            return datatabl;
        }

        public DataTable getModules()
        {
            string query = @"SELECT * FROM Modules";
            SqlDataAdapter datadapt = new SqlDataAdapter(query, connectStr);
            DataTable datatabl = new DataTable();
            datadapt.Fill(datatabl);
            return datatabl;
        }

    }
}
