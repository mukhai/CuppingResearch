namespace CuppingTherapy
{
    partial class HomeUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeWelcome1 = new CuppingTherapy.HomeWelcome();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 44);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // homeWelcome1
            // 
            this.homeWelcome1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeWelcome1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homeWelcome1.Location = new System.Drawing.Point(11, 52);
            this.homeWelcome1.Name = "homeWelcome1";
            this.homeWelcome1.Size = new System.Drawing.Size(1056, 623);
            this.homeWelcome1.TabIndex = 13;
            this.homeWelcome1.Load += new System.EventHandler(this.homeWelcome1_Load);
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homeWelcome1);
            this.Controls.Add(this.panel1);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1080, 700);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private HomeWelcome homeWelcome1;
    }
}
