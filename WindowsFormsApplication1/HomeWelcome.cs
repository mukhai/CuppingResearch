using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuppingTherapy
{
    public partial class HomeWelcome : UserControl
    {
        public HomeWelcome()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CuppingTherapy.MyTreatment b = new MyTreatment();
            b.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuppingTherapy.Registeration A = new CuppingTherapy.Registeration();
            A.Show();
        }

        private void HomeWelcome_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuppingTherapy.MyTreatment c = new CuppingTherapy.MyTreatment();
            c.Show();
        }
    }
}
