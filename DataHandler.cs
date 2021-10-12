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

        public DataTable DisplayStudents()
        {
            SqlConnection connect = new SqlConnection(connectStr);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetStudents",connect);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable DisplayModules()
        {
            SqlConnection connect = new SqlConnection(connectStr);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetModules", connect);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable SearchStudents(int id)
        {
            using (SqlConnection connect = new SqlConnection(connectStr))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudents", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                connect.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public DataTable SearchModules(string code)
        {
            using (SqlConnection connect = new SqlConnection(connectStr))
            {
                SqlCommand cmd = new SqlCommand("spSearchModules", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                connect.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
        public void UpdateStudents(int id,string name, string surname, string imagepath, string dob, string gender, string phone, string address, string modulecodes)
        {
            using (SqlConnection connect = new SqlConnection(connectStr))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudents",connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@Pic", imagepath);
                cmd.Parameters.AddWithValue("@Dob", dob);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Modulecodes", modulecodes);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateModules(string code,string name,string desc, string link)
        {
            using (SqlConnection connect = new SqlConnection(connectStr))
            {
                SqlCommand cmd = new SqlCommand("spUpdateModules", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@Link", link);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
