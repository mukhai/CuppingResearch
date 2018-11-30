namespace CuppingTherapy
{
    partial class Research
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
            this.btnHypertension = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAsthma = new System.Windows.Forms.Button();
            this.researchBackpain1 = new CuppingTherapy.ResearchBackpain();
            this.researchHypertension1 = new CuppingTherapy.ResearchHypertension();
            this.researchHistory1 = new CuppingTherapy.ResearchHistory();
            this.researchAsthma1 = new CuppingTherapy.ResearchAsthma();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnAsthma);
            this.panel1.Controls.Add(this.btnHypertension);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 44);
            this.panel1.TabIndex = 13;
            // 
            // btnHypertension
            // 
            this.btnHypertension.BackColor = System.Drawing.Color.DarkGray;
            this.btnHypertension.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHypertension.FlatAppearance.BorderSize = 0;
            this.btnHypertension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHypertension.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHypertension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHypertension.Location = new System.Drawing.Point(307, -1);
            this.btnHypertension.Name = "btnHypertension";
            this.btnHypertension.Size = new System.Drawing.Size(175, 45);
            this.btnHypertension.TabIndex = 16;
            this.btnHypertension.Text = "Hypertension";
            this.btnHypertension.UseVisualStyleBackColor = false;
            this.btnHypertension.Click += new System.EventHandler(this.btnHypertension_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(141, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Backpain";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.DarkGray;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistory.Location = new System.Drawing.Point(0, -1);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(160, 45);
            this.btnHistory.TabIndex = 14;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.researchAsthma1);
            this.panel2.Controls.Add(this.researchBackpain1);
            this.panel2.Controls.Add(this.researchHypertension1);
            this.panel2.Controls.Add(this.researchHistory1);
            this.panel2.Location = new System.Drawing.Point(11, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 623);
            this.panel2.TabIndex = 14;
            // 
            // btnAsthma
            // 
            this.btnAsthma.BackColor = System.Drawing.Color.DarkGray;
            this.btnAsthma.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAsthma.FlatAppearance.BorderSize = 0;
            this.btnAsthma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsthma.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsthma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsthma.Location = new System.Drawing.Point(476, -1);
            this.btnAsthma.Name = "btnAsthma";
            this.btnAsthma.Size = new System.Drawing.Size(175, 45);
            this.btnAsthma.TabIndex = 17;
            this.btnAsthma.Text = "Asthma";
            this.btnAsthma.UseVisualStyleBackColor = false;
            this.btnAsthma.Click += new System.EventHandler(this.btnAsthma_Click);
            // 
            // researchBackpain1
            // 
            this.researchBackpain1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.researchBackpain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.researchBackpain1.Location = new System.Drawing.Point(0, 0);
            this.researchBackpain1.Name = "researchBackpain1";
            this.researchBackpain1.Size = new System.Drawing.Size(1056, 623);
            this.researchBackpain1.TabIndex = 3;
            // 
            // researchHypertension1
            // 
            this.researchHypertension1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.researchHypertension1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.researchHypertension1.Location = new System.Drawing.Point(0, 0);
            this.researchHypertension1.Name = "researchHypertension1";
            this.researchHypertension1.Size = new System.Drawing.Size(1056, 623);
            this.researchHypertension1.TabIndex = 2;
            this.researchHypertension1.Load += new System.EventHandler(this.researchHypertension1_Load);
            // 
            // researchHistory1
            // 
            this.researchHistory1.AutoScroll = true;
            this.researchHistory1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.researchHistory1.Location = new System.Drawing.Point(0, 0);
            this.researchHistory1.Name = "researchHistory1";
            this.researchHistory1.Size = new System.Drawing.Size(1056, 623);
            this.researchHistory1.TabIndex = 0;
            // 
            // researchAsthma1
            // 
            this.researchAsthma1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.researchAsthma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.researchAsthma1.Location = new System.Drawing.Point(0, 0);
            this.researchAsthma1.Name = "researchAsthma1";
            this.researchAsthma1.Size = new System.Drawing.Size(1056, 623);
            this.researchAsthma1.TabIndex = 4;
            // 
            // Research
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Research";
            this.Size = new System.Drawing.Size(1080, 700);
            this.Load += new System.EventHandler(this.Research_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHistory;
        public History terminology1;
        private System.Windows.Forms.Panel panel2;
        private ResearchHistory researchHistory1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHypertension;
        private ResearchHypertension researchHypertension1;
        private ResearchBackpain researchBackpain1;
        private System.Windows.Forms.Button btnAsthma;
        private ResearchAsthma researchAsthma1;
    }
}
