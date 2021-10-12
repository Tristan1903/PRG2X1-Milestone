using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG2X1_Milestone
{
    class File_Handler
    {
        string GLUsername;
        string GlPassword;
        bool user_exsits_Login;
        bool pass_correct;

        public void create_File()
        {                   
            if (File.Exists("../usernames.txt") == false)
            {
                FileStream fs = File.Create("../usernames.txt");
            }
            
            if (File.Exists("../passwords.txt") == false)
            {
                FileStream fs = File.Create("../passwords.txt");
            }
            
        }
        
        public bool Logining_in(string Username, string Password)
        {
            bool message;

            GLUsername = Username;
            GlPassword = Password;

            Login_Reader();

            if (user_exsits_Login == true && pass_correct == true)
            {
                message = true;
            }
            else
            {
                message = false;
            }

            return message;
        }

        

        public void Login_Reader()
        {
            using StreamReader username_File = new StreamReader("../usernames.txt");
            using StreamReader pass_file = new StreamReader("../passwords.txt");
            string read_User;
            string read_Pass;
            while ((read_User = username_File.ReadLine()) != null)
            {
                if (read_User == GLUsername)
                {
                    user_exsits_Login = true;

                    while ((read_Pass = pass_file.ReadLine()) != null)
                    {
                        if (read_Pass == GlPassword)
                        {
                            pass_correct = true;
                        }
                        else
                        {
                            pass_correct = false;
                        }
                    }

                }
                else
                {
                    user_exsits_Login = false;
                }
            }               
                
        }

        string RegUsername;
        string RegPassword;
        bool user_exsits_Reg;

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
                    user_exsits_Reg = true;

                }
                else
                {
                    user_exsits_Reg = false;
                }
            }

            return user_exsits_Reg;

        }

        public void Registration_Writer()
        {
            using StreamWriter swUser = new StreamWriter("../usernames.txt", append: true);
            using StreamWriter swPass = new StreamWriter("../passwords.txt", append: true);

            swUser.WriteLine(RegUsername);
            swPass.WriteLine(RegPassword);

        }
    }
}
