using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuppingTherapy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PatientData.accdb";
            conn.Open();

            String str = "select * from Admin where USERNAME = '" + textBox1.Text + "' And PASSWORD = '" + textBox2.Text+ "'";
            OleDbCommand com = new OleDbCommand(str, conn);
            OleDbDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                WindowsFormsApplication1.MainPage c = new WindowsFormsApplication1.MainPage();
               //     CuppingTherapy.HomeUC a = new HomeUC();
               // CuppingTherapy.HomeWelcome b = new HomeWelcome();
               //    a.Enabled = true;
               //    b.Enabled = true;
               //     c.Enabled = true;
                c.Show();
                this.Hide();
                c.FormClosing += Frm2_Closing;

            }
            else
            {
                MessageBox.Show("The Username and password is not exist, please contact your manager");
            }
          
            conn.Close();
            reader.Close();
        }
        private void Frm2_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
