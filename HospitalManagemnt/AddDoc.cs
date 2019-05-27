using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagemnt
{
    public partial class AddDoc : Form
    {
        GlobalVariables global = new GlobalVariables();
        public AddDoc()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int doctorID = int.Parse(DocIDTextBox.Text);
            string doctorName = txt_Name.Text;
            string surname = surnameTextBox.Text;
            string dept = deptComboBox.Text;
            string phone = phoneTextBox.Text;
            string address = addressTextBox.Text;
            string email = email_textBox.Text;

            string query = "Insert into DoctorRecords(DoctorId, Name, Surname, Dept, Phone, Address, Email) values('" + doctorID + "','" + doctorName + "','" + surname + "','" + dept + "','" + phone + "','" + address + "','" + email + "')";

            try
            {
                if (global.newInsertSqlConnection(query))
                {
                    MessageBox.Show("Record Entered Successfully.");
                }
                else
                {
                    MessageBox.Show("Error, Process Failed.");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void step2TabPage_Click(object sender, EventArgs e)
        {

        }

        private void step1TabPage_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlForm Cf = new ControlForm();
            Cf.Show();
        }

        private void AddDoc_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
