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
            DataHandler AddStudent = new DataHandler();
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
            try
            {
                if (txtSdID.Text == string.Empty || txtSDName.Text == string.Empty || txtSDSurname.Text == string.Empty || txtimage.Text == string.Empty || txtDOB.Text == string.Empty ||
                    txtGender.Text == string.Empty || txtPhone.Text == string.Empty || txtAddress.Text == string.Empty || txtCodes.Text == string.Empty)
                {
                    throw new EmptyTextBoxException("Please make sure all text boxes have values");
                }
                AddStudent.Add_Student(ID_Capture, Name_Capture, Surname_Capture, Path_Capture, DateOBirth_Capture, Gender_Capture, Phone_Capture, Address_Capture, Course_Capture);
                MessageBox.Show("Student succesfully added");
            }
            catch(EmptyTextBoxException etb)
            {
                MessageBox.Show(etb.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to add student : " +ex.Message);
            }
    
            Display open = new Display();
            this.Hide();
            open.Show();

        }
    }
}
