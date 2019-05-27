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
    public partial class ExistingPatientForm : Form
    {
        GlobalVariables global = new GlobalVariables();
        public ExistingPatientForm()
        {
            InitializeComponent();
        }

        private void ExistingPatientForm_Load(object sender, EventArgs e)
        {
            string query = "select * from PatientRecords";
            dataGridView_ExistingPatients.DataSource = global.newSqlDataSetConnection(query).Tables[0];

            try
            {
                dataGridView_ExistingPatients.DataSource = global.newSqlDataSetConnection(query).Tables[0];
                Console.Write(query);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlForm Cf = new ControlForm();
            Cf.Show();
        }
    }
}
