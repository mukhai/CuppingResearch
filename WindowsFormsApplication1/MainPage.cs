using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainPage : Form
    {
      
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            homeUC1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuppingTherapy.MyTreatment mt = new CuppingTherapy.MyTreatment();
            mt.Show();
            this.Enabled = false;
            mt.FormClosing += formEnable;
        }

        private void formEnable(object sender, FormClosingEventArgs e)
        {
            this.Show();
            Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            about1.BringToFront();
        }

        public void btnTerminology_click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeUC1.BringToFront();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {

        }

        private void navHome1_Load(object sender, EventArgs e)
        {

        }

        private void navAbout1_Load(object sender, EventArgs e)
        {
            
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            research1.BringToFront();
        }

        private void research1_Load(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click_1(object sender, EventArgs e)
        {
            CuppingTherapy.Patient p = new CuppingTherapy.Patient();
            p.Show();
            this.Enabled = false;
            p.FormClosing += formEnable;
        }

        private void about1_Load(object sender, EventArgs e)
        {

        }

        private void homeUC1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuppingTherapy.PatientHistory p = new CuppingTherapy.PatientHistory();
           // Enabled = false;
            p.Show();
            
        }

        private void enableForm()
        {
            Enabled = true;
        }
    }
}
