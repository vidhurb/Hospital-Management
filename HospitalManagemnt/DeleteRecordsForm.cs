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
    public partial class DeleteRecordsForm : Form
    {
        GlobalVariables global = new GlobalVariables();
        public DeleteRecordsForm()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlForm Cf = new ControlForm();
            Cf.Show();
        }

        private void DeleteRecordsForm_Load(object sender, EventArgs e)
        {
            gridFill();
        }

        private void dataGridView_DeleteRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_DeleteRecords.SelectedRows)
            {
                MessageBox.Show(dataGridView_DeleteRecords.Rows.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredSSN = ssnTextBox.Text;
            string query = "Delete  from PatientRecords where SsnId = '"+ enteredSSN +"'";
            try
            {
                if (global.newInsertSqlConnection(query))
                {
                    MessageBox.Show("Deleted Successfully.");
                }
                else
                {
                    MessageBox.Show("Deletion Failed.");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Error");
            }
            gridFill();
        }

        private void dataGridView_DeleteRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_DeleteRecords.SelectedRows)
            {
                MessageBox.Show(dataGridView_DeleteRecords.Rows.ToString());
            }
        }

        private void gridFill()
        {
            string query = "Select * from PatientRecords";
            dataGridView_DeleteRecords.DataSource = global.newSqlDataSetConnection(query).Tables[0];

            try
            {
                dataGridView_DeleteRecords.DataSource = global.newSqlDataSetConnection(query).Tables[0];
                Console.Write(query);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
        }
    }
}
