using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CuppingTherapy
{
    public partial class ResearchBackpain: UserControl
    {
        public ResearchBackpain()
        {
            InitializeComponent();
        }

        private void ResearchBackpain_Load(object sender, EventArgs e)
        {
           
            string fullPath = @"D:\MyJorney\DrYuhaniProject\version3\WindowsFormsApplication1\Resources\Matrices\matricesBackpain.txt";
           // string fullPath = @"C:\Users\msipc\Source\Repos\cupping\WindowsFormsApplication1\Resources\Matrices\matricesBackpain.txt";
            string MatricesFilePath = @".\Resources\Matrices\matricesBackpain.txt";
            string inputBackpain = File.ReadAllText(fullPath);

            int x = 0, i = 0, j = 0;

            var labels = new[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10,
                label11, label12, label13, label14, label15, label16, label17, label18, label19, label20,
                label21, label22, label23, label24, label25, label26, label27, label28, label29, label30,
                label31, label32, label33, label34, label35, label36, label37, label38, label39, label40,
                label41, label42, label43, label44, label45, label46, label47, label48, label49, label50,
                label51, label52, label53, label54, label55, label56, label57, label58, label59, label60,
                label61, label62, label63, label64, label65, label66, label67, label68, label69, label70,
                label71, label72, label73, label74, label75, label76, label77, label78, label79, label80,
                label81, label82, label83, label84, label85, label86, label87, label88, label89, label90,
                label91, label92, label93, label94, label95, label96, label97, label98, label99, label100};
            
            int[,] result = new int[10, 10];

            foreach (var row in inputBackpain.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    result[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }

            x = 0;
            i = 0;
            while (i < 10)
            {
                j = 0;
                while (j < 10)
            {
                labels[x].Text = Convert.ToString(result[i, j]);
                if (labels[x].Text == "0") 
                    {
                        tblMatrices.GetControlFromPosition(i+1, j+1).BackColor = Color.DarkGray; // change color if its ZERO
                    }

                j++;
                x++;
            }
            i++;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCuppingPoint_Click(object sender, EventArgs e)
        {
            pnlGraph.Visible = false;
            pnlMatrices.Visible = false;
            pnlCuppingPoints.Visible = true;
            pnlCuppingPoints.BringToFront();
        }

        private void btnMatrices_Click(object sender, EventArgs e)
        {
            pnlGraph.Visible = false;
            pnlMatrices.Visible = true;
            pnlCuppingPoints.Visible = false;
            pnlMatrices.BringToFront();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            pnlGraph.Visible = true;
            pnlMatrices.Visible = false;
            pnlCuppingPoints.Visible = false;
            pnlGraph.BringToFront();
        }
    }
}
