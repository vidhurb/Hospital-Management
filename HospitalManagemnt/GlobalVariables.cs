using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagemnt
{
    class GlobalVariables
    {
        static private SqlConnection connectionHospital = new SqlConnection(@"Data Source=ASUS-VIVOBOOK;Initial Catalog=Hospital;Integrated Security=True");



        public DataSet newSqlDataSetConnection(string query)
        {

            if (GlobalVariables.connectionHospital.State == ConnectionState.Closed) { GlobalVariables.connectionHospital.Open(); }
            SqlDataAdapter da = new SqlDataAdapter(query, GlobalVariables.connectionHospital);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (GlobalVariables.connectionHospital.State == ConnectionState.Open) { GlobalVariables.connectionHospital.Close(); }
            return ds;

        }

        public bool newInsertSqlConnection(string query)
        {
            try
            {
                if (GlobalVariables.connectionHospital.State == ConnectionState.Closed) { GlobalVariables.connectionHospital.Open(); }
                SqlCommand command = new SqlCommand(query, GlobalVariables.connectionHospital);
                command.ExecuteNonQuery();
                if (GlobalVariables.connectionHospital.State == ConnectionState.Open) { GlobalVariables.connectionHospital.Close(); }
                return true;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
                return false;
            }
        }

        //Function TO Validate Text Fields
        public bool ValidateText(string Text)
        {
            if (string.IsNullOrEmpty(Text))
            {
                MessageBox.Show("Some fields are empty");
                return false;
            }
            return true;
        }

        public bool numberValidation(String fieldText)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(fieldText, "[^0-9]") && ValidateText(fieldText))
            {
                MessageBox.Show("Certain fields take only numbers");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
