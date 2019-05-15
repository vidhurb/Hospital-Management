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
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void btn_NewPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patientform pf = new Patientform();
            pf.Show();
        }

        private void btn_DoctorDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDoc Ad = new AddDoc();
            Ad.Show();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Existingpatients_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExistingPatientForm exp = new ExistingPatientForm();
            exp.Show();
        }

        private void btn_DeleteRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteRecordsForm Drf = new DeleteRecordsForm();
            Drf.Show();
        }
    }
}
