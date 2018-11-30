using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CuppingTherapy
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
    
            DateTime today = DateTime.Today;
            label4.Text = today.ToString("dd/MM/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String gender;
            if (rdMale.Checked)
            {
                gender = rdMale.Text;
            } else
            {
                gender = rdFemale.Text;
            }

           
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PatientData.accdb";

            try
            {
                conn.Open();
                String patientName = tbName.Text;
                String patientIC = tbIC.Text;
                String phone = tbPhoneNo.Text;
                String patientGender = gender;
                String patientRegisterDate = label4.Text;
                String my_querry = "INSERT INTO Registeration(PATIENT_NAME,PATIENT_IC,PATIENT_GENDER,REGISTERATION_DATE,PATIENT_PHONE)VALUES('" +
                    patientName + "','" + patientIC + "','" + patientGender + "','" + patientRegisterDate + "','" + phone  + "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data saved successfuly...!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            this.Close();
        
           

        }

        private void Registeration_Load(object sender, EventArgs e)
        {

        }
    }
}
