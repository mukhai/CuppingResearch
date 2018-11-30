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
    public partial class Research : UserControl
    {
        public Research()
        {
            InitializeComponent();
        }

        private void Research_Load(object sender, EventArgs e)
        {
            researchHistory1.BringToFront();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            researchHistory1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            researchBackpain1.BringToFront();
        }

        private void btnHypertension_Click(object sender, EventArgs e)
        {
            researchHypertension1.BringToFront();
        }

        private void researchHypertension1_Load(object sender, EventArgs e)
        {

        }

        private void btnAsthma_Click(object sender, EventArgs e)
        {
            researchAsthma1.BringToFront();
        }
    }
}
