﻿using System;
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
    public partial class ResearchAsthma : UserControl
    {
        public ResearchAsthma()
        {
            InitializeComponent();
        }

        private void ResearchAsthma_Load(object sender, EventArgs e)
        {
            string fullPath = @"D:\MyJorney\DrYuhaniProject\version3\WindowsFormsApplication1\Resources\Matrices\matricesAsthma.txt";
            //string fullPath = @"C:\Users\msipc\Source\Repos\cupping\WindowsFormsApplication1\Resources\Matrices\matricesAsthma.txt";
            string MatricesFilePath = @".\Resources\Matrices\matricesAsthma.txt";
            String inputAsthma = File.ReadAllText(fullPath);

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
                label91, label92, label93, label94, label95, label96, label97, label98, label99, label100,

                label101, label102, label103, label104, label105, label106, label107, label108, label109, label110,
                label111, label112, label113, label114, label115, label116, label117, label118, label119, label120,
                label121, label122, label123, label124, label125, label126, label127, label128, label129, label130,
                label131, label132, label133, label134, label135, label136, label137, label138, label139, label140,
                label141, label142, label143, label144, label145, label146, label147, label148, label149, label150,
                label151, label152, label153, label154, label155, label156, label157, label158, label159, label160,
                label161, label162, label163, label164, label165, label166, label167, label168, label169, label170,
                label171, label172, label173, label174, label175, label176, label177, label178, label179, label180,
                label181, label182, label183, label184, label185, label186, label187, label188, label189, label190,
                label191, label192, label193, label194, label195, label196,};

            int[,] resultAsthma = new int[14, 14]; // Asthma is 14 by 14

            foreach (var row in inputAsthma.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    resultAsthma[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }

            x = 0;
            i = 0;
            while (i < 14)
            {
                j = 0;
                while (j < 14)
            {
                labels[x].Text = Convert.ToString(resultAsthma[i, j]);
                if (labels[x].Text == "0") 
                    {
                       tblMatricesAsthma.GetControlFromPosition(i+1, j+1).BackColor = Color.DarkGray; // change color if its ZERO
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

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
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
