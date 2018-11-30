namespace WindowsFormsApplication1
{
    partial class MainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button6;
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelNav1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.homeUC1 = new CuppingTherapy.HomeUC();
            this.research1 = new CuppingTherapy.Research();
            this.about1 = new CuppingTherapy.About();
            button6 = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.panelNav1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button6.Image = global::CuppingTherapy.Properties.Resources.gear1_32px_white;
            button6.Location = new System.Drawing.Point(989, 0);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(48, 45);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.homeUC1);
            this.panelContent.Controls.Add(this.research1);
            this.panelContent.Controls.Add(this.about1);
            this.panelContent.Location = new System.Drawing.Point(0, 45);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1080, 700);
            this.panelContent.TabIndex = 5;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // panelNav1
            // 
            this.panelNav1.BackColor = System.Drawing.Color.Gray;
            this.panelNav1.Controls.Add(this.button1);
            this.panelNav1.Controls.Add(this.btnResearch);
            this.panelNav1.Controls.Add(button6);
            this.panelNav1.Controls.Add(this.button7);
            this.panelNav1.Controls.Add(this.btnPatient);
            this.panelNav1.Controls.Add(this.btnAbout);
            this.panelNav1.Controls.Add(this.btnHome);
            this.panelNav1.Controls.Add(this.btnTreatment);
            this.panelNav1.Location = new System.Drawing.Point(0, 0);
            this.panelNav1.Name = "panelNav1";
            this.panelNav1.Size = new System.Drawing.Size(1080, 45);
            this.panelNav1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(467, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.FlatAppearance.BorderSize = 0;
            this.btnResearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResearch.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResearch.Location = new System.Drawing.Point(775, 0);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(158, 45);
            this.btnResearch.TabIndex = 7;
            this.btnResearch.Text = "Research";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::CuppingTherapy.Properties.Resources.power1_32px_white;
            this.button7.Location = new System.Drawing.Point(1036, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 45);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatient.Location = new System.Drawing.Point(316, 0);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(160, 45);
            this.btnPatient.TabIndex = 3;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click_1);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbout.Location = new System.Drawing.Point(621, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(158, 45);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(160, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTreatment
            // 
            this.btnTreatment.FlatAppearance.BorderSize = 0;
            this.btnTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreatment.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreatment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTreatment.Location = new System.Drawing.Point(160, 0);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(160, 45);
            this.btnTreatment.TabIndex = 2;
            this.btnTreatment.Text = "Treatment";
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.button2_Click);
            // 
            // homeUC1
            // 
            this.homeUC1.AutoSize = true;
            this.homeUC1.Location = new System.Drawing.Point(3, -3);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(1083, 700);
            this.homeUC1.TabIndex = 0;
            this.homeUC1.Load += new System.EventHandler(this.homeUC1_Load);
            // 
            // research1
            // 
            this.research1.Location = new System.Drawing.Point(0, 0);
            this.research1.Name = "research1";
            this.research1.Size = new System.Drawing.Size(1080, 700);
            this.research1.TabIndex = 2;
            this.research1.Load += new System.EventHandler(this.research1_Load);
            // 
            // about1
            // 
            this.about1.Location = new System.Drawing.Point(0, 0);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(1080, 682);
            this.about1.TabIndex = 1;
            this.about1.Load += new System.EventHandler(this.about1_Load);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 740);
            this.Controls.Add(this.panelNav1);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelNav1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelNav1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Button btnResearch;
        private CuppingTherapy.About about1;
        private CuppingTherapy.Research research1;
        private CuppingTherapy.Treatment treatment1;
        private System.Windows.Forms.Button button1;
        private CuppingTherapy.HomeUC homeUC1;
    }
}

