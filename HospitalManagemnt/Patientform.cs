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
    public partial class Patientform : Form
    {

        GlobalVariables global = new GlobalVariables();
        public Patientform()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void Patientform_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Seriousness_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void birth_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void birth_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void birth_placeLabel_Click(object sender, EventArgs e)
        {

        }

        private void birth_placeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void father_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void father_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Seriousness_Click(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexLabel_Click(object sender, EventArgs e)
        {

        }

        private void txt_Complaint_TextChanged(object sender, EventArgs e)
        {

        }

        private void ssnLabel_Click(object sender, EventArgs e)
        {

        }

        private void ssnTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inspectionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlForm Cf = new ControlForm();
            Cf.Show();
        }

        private void step2TabPage_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ControlForm Cf = new ControlForm();
            Cf.Show();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            int ssnId = 0;
            string patientFirstName = nameTextBox.Text;
            string patientLastName = surnameTextBox.Text;
            string gender = sexComboBox.Text;
            string bloodType = comboBox_bloodgroup.Text;
            string Seriousness = comboBox_Seriousness.Text;
            string complaint = txtbx_Complaint.Text;
            string AttendingDoctor = doctorComboBox.Text;
            string Department = deptComboBox.Text;
            string DOB = birth_dateDateTimePicker.Value.ToString("dd-MMM-yyyy");
            string AppointmentDate = inspectionDateTimePicker.Value.ToString("dd-MMM-yyyy");
            string PlaceOfBirth = birth_placeTextBox.Text;
            string FatherName= father_nameTextBox.Text;
            string Address = addressTextBox.Text;
            string Phone = phoneTextBox.Text;


            try
            {
                ssnId = int.Parse(ssnTextBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid SSN Number.");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No Entry Found");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }

            try
            {
                String query = "Insert into PatientRecords(ssnId, PatientFirstName, PatientLastName, Gender, BloodType, Seriousness, Complaint, AttendingDoctor, DOB, PlaceOfBirth, FatherName, Phone, AppointmentDate, Department, Address) Values('" + ssnId + "','" + patientLastName + "','" + patientLastName + "','" + gender + "','" + bloodType + "','" + Seriousness + "','" + complaint + "','" + AttendingDoctor + "','" + DOB + "','" + PlaceOfBirth + "','" + FatherName + "','" + Phone + "','" + AppointmentDate + "','" + Department + "','" + Address + "')";

                try
                {
                    if (global.newInsertSqlConnection(query))
                    {
                        MessageBox.Show("Submitted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error, Process Failed.");
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Error" + ee);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
            }


        }

        private void birth_placeTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
