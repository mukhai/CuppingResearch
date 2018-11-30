namespace CuppingTherapy
{
    partial class About
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
            this.btnSoftware = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutThisSoftware1 = new CuppingTherapy.AboutThisSoftware();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSoftware
            // 
            this.btnSoftware.BackColor = System.Drawing.Color.DarkGray;
            this.btnSoftware.FlatAppearance.BorderSize = 0;
            this.btnSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftware.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftware.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSoftware.Location = new System.Drawing.Point(0, 0);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(160, 45);
            this.btnSoftware.TabIndex = 6;
            this.btnSoftware.Text = "Software";
            this.btnSoftware.UseVisualStyleBackColor = false;
            this.btnSoftware.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnSoftware);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 46);
            this.panel1.TabIndex = 9;
            // 
            // aboutThisSoftware1
            // 
            this.aboutThisSoftware1.Location = new System.Drawing.Point(12, 51);
            this.aboutThisSoftware1.Name = "aboutThisSoftware1";
            this.aboutThisSoftware1.Size = new System.Drawing.Size(1056, 623);
            this.aboutThisSoftware1.TabIndex = 10;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.Controls.Add(this.aboutThisSoftware1);
            this.Controls.Add(this.panel1);
            this.Name = "About";
            this.Size = new System.Drawing.Size(1080, 682);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Panel panel1;
        private AboutThisSoftware aboutThisSoftware1;
    }
}
