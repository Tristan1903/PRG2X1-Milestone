using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG2X1_Milestone
{
    class User_registration_Handler
    {
        string RegUsername;
        string RegPassword;
        bool user_exsits;

        public void Set_Values(string Get_username, string Get_password)
        {
            RegUsername = Get_username;
            RegPassword = Get_password;            
        }

        
        public bool User_Exsistance(string user)
        {
            StreamReader username_File = new StreamReader("usernames.txt");
            
            string read_User;
            
            while ((read_User = username_File.ReadLine()) != null)
            {
                if (read_User == user)
                {
                    user_exsits = true;         

                }
                else
                {
                    user_exsits = false;
                }
            }

            return user_exsits;

        }

        public void Registration_Writer()
        {
            using StreamWriter swUser = new StreamWriter("usernames.txt", append: true);
            using StreamWriter swPass = new StreamWriter("passwords.txt", append: true);

            swUser.WriteLine(RegUsername);
            swPass.WriteLine(RegPassword);

        }

    }
}
