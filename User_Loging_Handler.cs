using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG2X1_Milestone
{
    class User_Loging_Handler
    {
        string GLUsername;
        string GlPassword;
        bool user_exsits;
        bool pass_correct;
        
        public bool Logining_in(string Username, string Password)
        {
            bool message;

            GLUsername = Username;
            GlPassword = Password;

            Login_Reader();

            if (user_exsits == true && pass_correct == true)
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
                    user_exsits = true;

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
                    user_exsits = false;
                }
            }               
                
        }   
    }
}
