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
    public partial class MyTreatment : Form
    {

      
        OleDbCommand com;
        string str;
        double x;
       
        //double cupBig = 7.00, cupSmall = 5.00;
        double totalPrice = 0.00;
        //int totalPoint = 0;
       

        public MyTreatment()
        {
            InitializeComponent();
        }

        private void MyTreatment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDataDataSet.Treatment' table. You can move, or remove it, as needed.
            //this.treatmentTableAdapter.Fill(this.patientDataDataSet.Treatment);
            DateTime today = DateTime.Today;
         lblTodayDate.Text = today.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PatientData.accdb";
            conn.Open();
          
             str = "select PATIENT_NAME from Registeration where PATIENT_IC = '" + tbIC.Text + "'";
            //str = "select PATIENT_NAME,LAST_APPOINTMENT from Registeration,Treatment where Registeration.PATIENT_IC ='"+ tbIC.Text + "' AND Treatment.PATIENT_IC = '" + tbIC.Text + "'";
            com = new OleDbCommand(str, conn);
            OleDbDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                tbName.Text = reader["PATIENT_NAME"].ToString();
                //txtLastDate.Text = reader["LAST_APPOINTMENT"].ToString();
                //tbCuppingPoint.Text = reader["pointSickness"].ToString();
                try
                {
                    OleDbDataAdapter od = new OleDbDataAdapter("select * from Treatment where PATIENT_IC = '" + tbIC.Text + "'", conn);
                    DataSet ds = new DataSet();
                    od.Fill(ds, "Treatment");
                    dataGridView1.DataSource = ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection because " + ex.Message + "!");
                }
               // this.treatmentTableAdapter.Fill(this.patientDataDataSet.Treatment);
            }
            else
            {
                MessageBox.Show("The IC is not exist, please register into the system");
            }

            conn.Close();
            reader.Close();         


          
        }

        private void ckI_CheckedChanged(object sender, EventArgs e)
        {
 

        }

        private void ckJ_CheckedChanged(object sender, EventArgs e)
        {
  
        }

        private void ckB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckD_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ckE_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ckC_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ckF_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void ckG_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckH_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckA_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            String A = "";
            String B = "";
            String C = "";
            String D = "";
            String E = "";
            String F = "";
            String G = "";
            String H = "";
            String I = "";
            String J = "";
            String K = "";
            String L = "";
            String M = "";
            String N = "";
            String O = "";
            String P = "";
            String Q = "";
            String R = "";
            String S = "";
          
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PatientData.accdb";

            try
            {
                conn.Open();
                //type
                String patientSickness = comboBox1.SelectedItem.ToString();
                String patientNextDate = dateTimePicker1.Value.ToString("d");

                String patientLastDate = lblTodayDate.Text;
                if (comboBox2.Text != "") {  A = comboBox2.SelectedItem.ToString(); }
                if (comboBox3.Text != "") {  B = comboBox3.SelectedItem.ToString(); }
                if (comboBox4.Text != "") {  C = comboBox4.SelectedItem.ToString(); }
                if (comboBox5.Text != "") {  D = comboBox5.SelectedItem.ToString(); }
                if (comboBox6.Text != "") {  E = comboBox6.SelectedItem.ToString(); }
                if (comboBox7.Text != "") {  F = comboBox7.SelectedItem.ToString(); }
                if (comboBox8.Text != "") {  G = comboBox8.SelectedItem.ToString(); }
                if (comboBox9.Text != "") {  H = comboBox9.SelectedItem.ToString(); }
                if (comboBox10.Text != "") {  I = comboBox10.SelectedItem.ToString(); }
                if (comboBox11.Text != "") {  J = comboBox11.SelectedItem.ToString(); }
                if (comboBox12.Text != "") { K = comboBox12.SelectedItem.ToString(); }
                if (comboBox13.Text != "") { L = comboBox13.SelectedItem.ToString(); }
                if (comboBox14.Text != "") { M = comboBox14.SelectedItem.ToString(); }
                if (comboBox15.Text != "") { N = comboBox15.SelectedItem.ToString(); }
                if (comboBox16.Text != "") { O = comboBox16.SelectedItem.ToString(); }
                if (comboBox17.Text != "") { P = comboBox17.SelectedItem.ToString(); }
                if (comboBox18.Text != "") { Q = comboBox18.SelectedItem.ToString(); }
                if (comboBox19.Text != "") { R = comboBox19.SelectedItem.ToString(); }
                if (comboBox20.Text != "") { S = comboBox20.SelectedItem.ToString(); }
               
                //if (comboBox12.Text != "")   
                //String K = comboBox12.SelectedItem.ToString();
                //String L = comboBox13.SelectedItem.ToString();
                // String M = comboBox14.SelectedItem.ToString();
                //  String N = comboBox15.SelectedItem.ToString();
                // String O = comboBox16.SelectedItem.ToString();
                //   // String pointSickness = tbCuppingPoint.Text;
                String cuppingPayment = lblRM.Text;
             


                String my_querry = "INSERT INTO Treatment(PATIENT_IC,LAST_APPOINTMENT,TYPE,PAYMENT,NEXT_APPOINTMENT,A,B,C,D,E,F,G,H,I,J)VALUES('" +
                    tbIC.Text + "','" + patientLastDate  + "','" + patientSickness + "','" + cuppingPayment +"','" + patientNextDate + "','"+ A + "','" + B + "','" + C + "','" + D + "','" + E + "','" + F + "','" + G + "','" + H + "','" + I + "','" + J + "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data update successfuly...!");


                //this.treatmentTableAdapter.Fill(this.patientDataDataSet.Treatment);
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

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
        
                if (comboBox2.Enabled)
                {
                if (comboBox2.Text != "")
                {
                    if (comboBox2.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox2.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox2.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point A is empty");
                }
                }
  



            if (comboBox3.Enabled)
            {
                if (comboBox3.Text != "")
                {
                    if (comboBox3.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox3.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox3.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point B is empty");
                }
            }

            if (comboBox4.Enabled)
            {
                    if (comboBox4.Text != "")
                    {
                        if (comboBox4.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox4.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox4.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point C is empty");
                }
            }

            if (comboBox5.Enabled)
            {
                        if (comboBox5.Text != "")
                        {
                            if (comboBox5.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox5.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox5.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point D is empty");
                }
            }

            if (comboBox6.Enabled)
            {
                            if (comboBox6.Text != "")
                            {
                                if (comboBox6.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox6.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox6.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point E is empty");
                }
            }

            if (comboBox7.Enabled)
            {
                                if (comboBox7.Text != "")
                                {
                                    if (comboBox7.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox7.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox7.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point F is empty");
                }
            }

            if (comboBox8.Enabled)
            {
                                    if (comboBox8.Text != "")
                                    {
                                        if (comboBox8.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox8.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox8.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point G is empty");
                }
            }

            if (comboBox9.Enabled)
                                    {
                                        if (comboBox9.Text != "")
                                        {
                                            if (comboBox9.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox9.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox9.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point H is empty");
                }
            }

            if (comboBox10.Enabled)
            {
                                            if (comboBox10.Text != "")
                                            {
                                                if (comboBox10.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox10.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox10.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point I is empty");
                }
            }

            if (comboBox11.Enabled)
            {
                 if (comboBox11.Text != "")
                {
                if (comboBox11.SelectedItem.ToString() == "BIG")
                {
                    totalPrice = totalPrice + 10.00;
                }
                else if (comboBox11.SelectedItem.ToString() == "MEDIUM")
                {
                    totalPrice = totalPrice + 7.00;
                }

                else if (comboBox11.SelectedItem.ToString() == "SMALL")
                {
                    totalPrice = totalPrice + 5.00;
                }
                else
                {
                    totalPrice = totalPrice + 0;
                }
                }
                else
                {
                    MessageBox.Show("Data from Point J is empty");
                }
            }

            if (comboBox12.Enabled)
            {
                if (comboBox12.Text != "")
                {
                    if (comboBox12.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox12.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox12.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point K is empty");
                }
            }

            if (comboBox13.Enabled)
            {
                if (comboBox13.Text != "")
                {
                    if (comboBox13.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox13.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox13.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point L is empty");
                }
            }

            if (comboBox14.Enabled)
            {
                if (comboBox14.Text != "")
                {
                    if (comboBox14.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox14.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox14.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point M is empty");
                }
            }

            if (comboBox15.Enabled)
            {
                if (comboBox15.Text != "")
                {
                    if (comboBox15.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox15.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox15.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point N is empty");
                }
            }

            if (comboBox16.Enabled)
            {
                if (comboBox16.Text != "")
                {
                    if (comboBox16.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox16.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox16.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point O is empty");
                }
            }

            if (comboBox17.Enabled)
            {
                if (comboBox17.Text != "")
                {
                    if (comboBox17.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox17.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox17.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point P is empty");
                }
            }

            if (comboBox18.Enabled)
            {
                if (comboBox18.Text != "")
                {
                    if (comboBox18.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox18.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox18.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point Q is empty");
                }
            }

            if (comboBox19.Enabled)
            {
                if (comboBox19.Text != "")
                {
                    if (comboBox19.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox19.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox19.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point R is empty");
                }
            }

            if (comboBox20.Enabled)
            {
                if (comboBox20.Text != "")
                {
                    if (comboBox20.SelectedItem.ToString() == "BIG")
                    {
                        totalPrice = totalPrice + 10.00;
                    }
                    else if (comboBox20.SelectedItem.ToString() == "MEDIUM")
                    {
                        totalPrice = totalPrice + 7.00;
                    }

                    else if (comboBox20.SelectedItem.ToString() == "SMALL")
                    {
                        totalPrice = totalPrice + 5.00;
                    }
                    else
                    {
                        totalPrice = totalPrice + 0;
                    }
                }
                else
                {
                    MessageBox.Show("Data from Point S is empty");
                }
            }

            lblRM.Text = "RM" + totalPrice;

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkI_CheckedChanged(object sender, EventArgs e)
        {
            if (chkI.Checked == true) 
                {
                comboBox10.Enabled = true;
               
                }
            else
            {
                comboBox10.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                comboBox4.Enabled = true;
            }
            else
            {
                comboBox4.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox6.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                comboBox5.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                comboBox7.Enabled = true;
            }
            else
            {
                comboBox7.Enabled = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                comboBox8.Enabled = true;
            }
            else
            {
                comboBox8.Enabled = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                comboBox9.Enabled = true;
            }
            else
            {
                comboBox9.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox11.Enabled = true;
            }
            else
            {
                comboBox11.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            totalPrice = 0;
            lblRM.Text = "RM 0.00";
        }

        private void tbIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "BACK PAIN") { panelBackPain.Visible = true; panelHypertension.Visible = false; panelAsthma.Visible = false; }
            if (comboBox1.SelectedItem.ToString() == "HYPERTENSION") { panelBackPain.Visible = true; panelHypertension.Visible = true; panelAsthma.Visible = false; }
            if (comboBox1.SelectedItem.ToString() == "ASTHMA") { panelBackPain.Visible = true; panelHypertension.Visible = false; panelAsthma.Visible = true; }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyB.Checked == true)
            {
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyC.Checked == true)
            {
                comboBox4.Enabled = true;
            }
            else
            {
                comboBox4.Enabled = false;
            }
        }

        private void ckHyA_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyA.Checked == true)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        private void ckHyB_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyB.Checked == true)
            {
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
            }
        }

        private void ckHyD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyD.Checked == true)
            {
                comboBox5.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
            }
        }

        private void ckHyE_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyE.Checked == true)
            {
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox6.Enabled = false;
            }
        }

        private void ckHyF_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyF.Checked == true)
            {
                comboBox7.Enabled = true;
            }
            else
            {
                comboBox7.Enabled = false;
            }
        }

        private void ckHyG_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyG.Checked == true)
            {
                comboBox8.Enabled = true;
            }
            else
            {
                comboBox8.Enabled = false;
            }
        }

        private void ckHyH_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyH.Checked == true)
            {
                comboBox9.Enabled = true;
            }
            else
            {
                comboBox9.Enabled = false;
            }
        }

        private void ckHyI_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyI.Checked == true)
            {
                comboBox10.Enabled = true;
            }
            else
            {
                comboBox10.Enabled = false;
            }
        }

        private void ckHyJ_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyJ.Checked == true)
            {
                comboBox11.Enabled = true;
            }
            else
            {
                comboBox11.Enabled = false;
            }
        }

        private void ckHyK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyK.Checked == true)
            {
                comboBox12.Enabled = true;
            }
            else
            {
                comboBox12.Enabled = false;
            }
        }

        private void ckHyL_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyL.Checked == true)
            {
                comboBox13.Enabled = true;
            }
            else
            {
                comboBox13.Enabled = false;
            }
        }

        private void ckHyM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyM.Checked == true)
            {
                comboBox14.Enabled = true;
            }
            else
            {
                comboBox14.Enabled = false;
            }
        }

        private void ckHyN_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyN.Checked == true)
            {
                comboBox15.Enabled = true;
            }
            else
            {
                comboBox15.Enabled = false;
            }
        }

        private void ckHyO_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyO.Checked == true)
            {
                comboBox16.Enabled = true;
            }
            else
            {
                comboBox16.Enabled = false;
            }
        }

        private void ckHyP_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyP.Checked == true)
            {
                comboBox17.Enabled = true;
            }
            else
            {
                comboBox17.Enabled = false;
            }
        }

        private void ckHyQ_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyQ.Checked == true)
            {
                comboBox18.Enabled = true;
            }
            else
            {
                comboBox18.Enabled = false;
            }
        }

        private void ckHyR_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyR.Checked == true)
            {
                comboBox19.Enabled = true;
            }
            else
            {
                comboBox19.Enabled = false;
            }
        }

        private void ckHyS_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHyS.Checked == true)
            {
                comboBox20.Enabled = true;
            }
            else
            {
                comboBox20.Enabled = false;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsD.Checked == true)
            {
                comboBox5.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
            }
        }

        private void ckAsA_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsA.Checked == true)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        private void ckAsB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckAsB.Checked == true)
            {
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
            }
        }

        private void ckAsC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsC.Checked == true)
            {
                comboBox4.Enabled = true;
            }
            else
            {
                comboBox4.Enabled = false;
            }
        }

        private void ckAsE_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsE.Checked == true)
            {
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox6.Enabled = false;
            }
        }

        private void ckAsF_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsF.Checked == true)
            {
                comboBox7.Enabled = true;
            }
            else
            {
                comboBox7.Enabled = false;
            }
        }

        private void ckAsG_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsG.Checked == true)
            {
                comboBox8.Enabled = true;
            }
            else
            {
                comboBox8.Enabled = false;
            }
        }

        private void ckAsH_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsH.Checked == true)
            {
                comboBox9.Enabled = true;
            }
            else
            {
                comboBox9.Enabled = false;
            }
        }

        private void ckAsK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsK.Checked == true)
            {
                comboBox12.Enabled = true;
            }
            else
            {
                comboBox12.Enabled = false;
            }
        }

        private void ckAsI_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsI.Checked == true)
            {
                comboBox10.Enabled = true;
            }
            else
            {
                comboBox10.Enabled = false;
            }
        }

        private void ckAsJ_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsJ.Checked == true)
            {
                comboBox11.Enabled = true;
            }
            else
            {
                comboBox11.Enabled = false;
            }
        }

        private void ckAsL_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsL.Checked == true)
            {
                comboBox13.Enabled = true;
            }
            else
            {
                comboBox13.Enabled = false;
            }
        }

        private void ckAsM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsM.Checked == true)
            {
                comboBox14.Enabled = true;
            }
            else
            {
                comboBox14.Enabled = false;
            }
        }

        private void ckAsN_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAsN.Checked == true)
            {
                comboBox15.Enabled = true;
            }
            else
            {
                comboBox15.Enabled = false;
            }
        }

        private void panelHypertension_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //lbldate.Text = dateTimePicker1.Value.ToString("d");
           
        }
    }
}
