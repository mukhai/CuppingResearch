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
    public partial class ResearchHypertension : UserControl
    {
        public ResearchHypertension()
        {
            InitializeComponent();
        }

        private void ResearchHypertension_Load(object sender, EventArgs e)
        {
            string fullPath = @"D:\MyJorney\DrYuhaniProject\version3\WindowsFormsApplication1\Resources\Matrices\matricesHypertension.txt";
            //string fullPath = @"C:\Users\msipc\Source\Repos\cupping\WindowsFormsApplication1\Resources\Matrices\matricesHypertension.txt";
            string MatricesFilePath = @".\Resources\Matrices\matricesHypertension.txt";
            String inputHyper = File.ReadAllText(fullPath);

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
                label191, label192, label193, label194, label195, label196, label197, label198, label199, label200,

                label201, label202, label203, label204, label205, label206, label207, label208, label209, label210,
                label211, label212, label213, label214, label215, label216, label217, label218, label219, label220,
                label221, label222, label223, label224, label225, label226, label227, label228, label229, label230,
                label231, label232, label233, label234, label235, label236, label237, label238, label239, label240,
                label241, label242, label243, label244, label245, label246, label247, label248, label249, label250,
                label251, label252, label253, label254, label255, label256, label257, label258, label259, label260,
                label261, label262, label263, label264, label265, label266, label267, label268, label269, label270,
                label271, label272, label273, label274, label275, label276, label277, label278, label279, label280,
                label281, label282, label283, label284, label285, label286, label287, label288, label289, label290,
                label291, label292, label293, label294, label295, label296, label297, label298, label299, label300,

                label301, label302, label303, label304, label305, label306, label307, label308, label309, label310,
                label311, label312, label313, label314, label315, label316, label317, label318, label319, label320,
                label321, label322, label323, label324, label325, label326, label327, label328, label329, label330,
                label331, label332, label333, label334, label335, label336, label337, label338, label339, label340,
                label341, label342, label343, label344, label345, label346, label347, label348, label349, label350,
                label351, label352, label353, label354, label355, label356, label357, label358, label359, label360,
                label361,};

            int[,] resultHyper = new int[19, 19];

            foreach (var row in inputHyper.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    resultHyper[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }

            x = 0;
            i = 0;
            while (i < 19)
            {
                j = 0;
                while (j < 19)
            {
                labels[x].Text = Convert.ToString(resultHyper[i, j]);
                if (labels[x].Text == "0") 
                    {
                       tblMatricesHyper.GetControlFromPosition(i+1, j+1).BackColor = Color.DarkGray; // change color if its ZERO
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

        private void label188_Click(object sender, EventArgs e)
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
