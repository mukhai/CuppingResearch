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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PatientData.accdb");
            conn.Open();
            try
            {
                OleDbDataAdapter od = new OleDbDataAdapter("select * from Registeration", conn);
                DataSet ds = new DataSet();
                od.Fill(ds, "Registeration");
                dataGridView1.DataSource = ds.Tables[0];

                OleDbDataAdapter od2 = new OleDbDataAdapter("select * from Treatment", conn);
                DataSet ds2 = new DataSet();
                od2.Fill(ds2, "Treatment");
                dataGridView2.DataSource = ds2.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection because " + ex.Message + "!");
            }
            // this.treatmentTableAdapter.Fill(this.patientDataDataSet.Treatment);
        }

    

        private void patientInfoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PatientData.accdb");
            conn.Open();

            string x = "";
            //if(textBox1.Text != "") { x = "select * from Registeration,Treatment where PATIENT_NAME = '" + textBox1.Text + "'"; }
            if (textBox2.Text != "") { x = "select * from Treatment where PATIENT_IC = '" + textBox2.Text + "'"; }
            if (textBox3.Text != "") { x = "select * from Treatment where TYPE = '" + textBox3.Text + "'"; }
            if (textBox2.Text != "" && textBox3.Text != "") { x = "select * from Treatment where PATIENT_IC = '" + textBox2.Text + "' AND TYPE ='" + textBox3.Text + "'"; }
            try
                {
                    OleDbDataAdapter od = new OleDbDataAdapter(x, conn);
                    DataSet ds = new DataSet();
                    od.Fill(ds, "Treatment");
                    dataGridView2.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection because " + ex.Message + "!");
                }
                //this.treatmentTableAdapter.Fill(this.patientDataDataSet.Treatment);
            


            conn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PatientData.accdb");
            conn.Open();
            try
            {
                OleDbDataAdapter od = new OleDbDataAdapter("select * from Registeration", conn);
                DataSet ds = new DataSet();
                od.Fill(ds, "Registeration");
                dataGridView1.DataSource = ds.Tables[0];

                OleDbDataAdapter od2 = new OleDbDataAdapter("select * from Treatment", conn);
                DataSet ds2 = new DataSet();
                od2.Fill(ds2, "Treatment");
                dataGridView2.DataSource = ds2.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection because " + ex.Message + "!");
            }
            // this.treatmentTableAdapter.Fill(this.patientDataDataSet.Treatment);
        }
    }
}
