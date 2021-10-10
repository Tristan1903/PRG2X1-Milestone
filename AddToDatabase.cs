using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PRG2X1_Milestone
{
    class AddToDatabase
    {
        string connectStr = "server=.;Initial Catalog=PRG2x1_Milestone_DB;Integrated Security=SSPI";
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

            ID_Add = Convert.ToString (ID);
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
            command.Parameters.AddWithValue("@dob",DateOBirth_Add );
            command.Parameters.AddWithValue("@gender", Gender_Add);
            command.Parameters.AddWithValue("@phone", Phone_Add);
            command.Parameters.AddWithValue("@address", Address_Add);
            command.Parameters.AddWithValue("@modules", Course_Add);

            command.ExecuteNonQuery();
        }
    }
}
