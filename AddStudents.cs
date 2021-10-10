using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2X1_Milestone
{
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToDatabase AddStudent = new AddToDatabase();
            string ID_Capture;
            string Name_Capture;
            string Surname_Capture;
            string Path_Capture;
            string DateOBirth_Capture;
            string Gender_Capture;
            string Phone_Capture;
            string Address_Capture;
            string Course_Capture;

            ID_Capture = txtSdID.Text;
            Name_Capture = txtSDName.Text;
            Surname_Capture = txtSDSurname.Text;
            Path_Capture = txtimage.Text;
            DateOBirth_Capture = txtDOB.Text;
            Gender_Capture = txtGender.Text;
            Phone_Capture = txtPhone.Text;
            Address_Capture = txtAddress.Text;
            Course_Capture = txtCodes.Text;

            AddStudent.Add_Student(ID_Capture, Name_Capture, Surname_Capture, Path_Capture, DateOBirth_Capture, Gender_Capture, Phone_Capture, Address_Capture, Course_Capture);
            MessageBox.Show("Student succesfully added");
            Display open = new Display();
            this.Hide();
            open.Show();

        }
    }
}
