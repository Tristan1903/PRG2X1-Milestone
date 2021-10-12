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
        SqlConnection con;
        public void Add_Student(string ID, string Name, string Surname, string Path, string DateOBirth, string Gender, string Phone, string Address, string Course)
        {
            con = new SqlConnection(connectStr);
            string ID_Add;
            string Name_Add;
            string Surname_Add;
            string Path_Add;
            string DateOBirth_Add;
            string Gender_Add;
            string Phone_Add;
            string Address_Add;
            string Course_Add;

            ID_Add = Convert.ToString(ID);
            Name_Add = Name;
            Surname_Add = Surname;
            Path_Add = Path;
            DateOBirth_Add = DateOBirth;
            Gender_Add = Gender;
            Phone_Add = Phone;
            Address_Add = Address;
            Course_Add = Course;

            String query = "INSERT INTO Student (StudentID,Name,Surname,StudentImage,DOB,Gender,Phone,Address,Modulecodes) VALUES (@id,@name,@surname,BulkColumn,@dob,@gender,@phone,@address,@modules)  FROM Openrowset (Bulk '" + Path_Add + "', Single_Blob) as Image";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@id", ID_Add);
            command.Parameters.AddWithValue("@name", Name_Add);
            command.Parameters.AddWithValue("@surname", Surname_Add);
            command.Parameters.AddWithValue("@dob", DateOBirth_Add);
            command.Parameters.AddWithValue("@gender", Gender_Add);
            command.Parameters.AddWithValue("@phone", Phone_Add);
            command.Parameters.AddWithValue("@address", Address_Add);
            command.Parameters.AddWithValue("@modules", Course_Add);

            command.ExecuteNonQuery();
        }

        public void Add_Modules(string Modulecode, string ModuleName, string ModuleDescription, string ModuleLink)
        {
            con = new SqlConnection(connectStr);
            string Modulecode_Add;
            string ModuleName_Add;
            string ModuleDescription_Add;
            string ModuleLink_Add;


            Modulecode_Add = Convert.ToString(Modulecode);
            ModuleName_Add = ModuleName;
            ModuleDescription_Add = ModuleDescription;
            ModuleLink_Add = ModuleLink;

            String query = "INSERT INTO Module (Modulecode,ModuleName,ModuleDesription,ModuleLink) VALUES (@Modulecode,@Modulename,@Moduledescription,@Modulelink)";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Modulecode", Modulecode_Add);
            command.Parameters.AddWithValue("@Modulename", ModuleName_Add);
            command.Parameters.AddWithValue("@Moduledescription", ModuleDescription_Add);
            command.Parameters.AddWithValue("@Modulelink", ModuleLink_Add);

            command.ExecuteNonQuery();
        }
    }
}
