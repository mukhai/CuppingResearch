namespace CuppingTherapy
{
    partial class Testx
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
            this.label1x = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1x
            // 
            this.label1x.AutoSize = true;
            this.label1x.Location = new System.Drawing.Point(424, 280);
            this.label1x.Name = "label1x";
            this.label1x.Size = new System.Drawing.Size(24, 13);
            this.label1x.TabIndex = 0;
            this.label1x.Text = "test";
            // 
            // Testx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1x);
            this.Name = "Testx";
            this.Size = new System.Drawing.Size(1048, 570);
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1x;
    }
}
