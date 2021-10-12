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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        DataHandler handlerobj = new DataHandler();
        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            txtAddress.Enabled = true;
            txtDOB.Enabled = true;
            txtSID.Enabled = true;
            txtSName.Enabled = true;
            txtSSurname.Enabled = true;
            txtImage.Enabled = true;
            txtGender.Enabled = true;
            txtPhone.Enabled = true;
            txtSMCodes.Enabled = true;
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    throw new EmptyTextBoxException("Please fill the text box with search term");
                }
                int studentid = int.Parse(textBox1.Text);
                dataGridView1.DataSource = handlerobj.SearchStudents(int.Parse(textBox1.Text)) ;
            }
            catch (EmptyTextBoxException et)
            {
                MessageBox.Show(et.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to find Student : " + ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            txtMcodes.Enabled = true;
            txtMDescrip.Enabled = true;
            txtMLink.Enabled = true;
            txtMName.Enabled = true;
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    throw new EmptyTextBoxException("Please fill in the text box with search term");
                }
                string modulecode = textBox1.Text;
                dataGridView1.DataSource = handlerobj.SearchModules(textBox1.Text);
            }
            catch (EmptyTextBoxException et)
            {
                MessageBox.Show(et.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to find Module : " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == string.Empty || txtSName.Text == string.Empty || txtSSurname.Text == string.Empty ||
                    txtImage.Text == string.Empty || txtDOB.Text == string.Empty || txtGender.Text == string.Empty || 
                    txtPhone.Text == string.Empty || txtAddress.Text == string.Empty || txtMcodes.Text == string.Empty)
                {
                    throw new EmptyTextBoxException("Please make sure all the text boxes are filled");
                }
                handlerobj.UpdateStudents(int.Parse(textBox1.Text), txtSName.Text, txtSSurname.Text, txtImage.Text,
                 txtDOB.Text, txtGender.Text, txtPhone.Text, txtAddress.Text, txtMcodes.Text);
            }
            catch (EmptyTextBoxException et)
            {
                MessageBox.Show(et.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Student : " + ex.Message);
            }
            Display display_info = new Display();
            this.Hide();
            display_info.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        { 
            try
            {
                if (textBox1.Text == string.Empty || txtMName.Text == string.Empty || txtMDescrip.Text == string.Empty ||
                    txtMLink.Text == string.Empty)
                {
                    throw new EmptyTextBoxException("Please make sure all the text boxes are filled");
                }
                handlerobj.UpdateModules(textBox1.Text, txtMName.Text, txtMDescrip.Text, txtMLink.Text);
            }
            catch (EmptyTextBoxException et)
            {
                MessageBox.Show(et.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Module : " + ex.Message);
            }

            Display display_info = new Display();
            this.Hide();
            display_info.Show();
        }
    }
}
