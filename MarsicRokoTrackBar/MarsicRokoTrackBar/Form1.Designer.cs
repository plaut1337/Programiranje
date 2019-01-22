namespace MarsicRokoTrackBar
{
    partial class Form1
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblVrijednost = new System.Windows.Forms.Label();
            this.txtBoxVrijednost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 21);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(287, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblVrijednost
            // 
            this.lblVrijednost.AutoSize = true;
            this.lblVrijednost.Location = new System.Drawing.Point(12, 93);
            this.lblVrijednost.Name = "lblVrijednost";
            this.lblVrijednost.Size = new System.Drawing.Size(124, 13);
            this.lblVrijednost.TabIndex = 1;
            this.lblVrijednost.Text = "Postavljena vrijednost je:";
            // 
            // txtBoxVrijednost
            // 
            this.txtBoxVrijednost.Location = new System.Drawing.Point(142, 90);
            this.txtBoxVrijednost.Name = "txtBoxVrijednost";
            this.txtBoxVrijednost.Size = new System.Drawing.Size(79, 20);
            this.txtBoxVrijednost.TabIndex = 2;
            this.txtBoxVrijednost.Text = "0";
            this.txtBoxVrijednost.TextChanged += new System.EventHandler(this.txtBoxVrijednost_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 142);
            this.Controls.Add(this.txtBoxVrijednost);
            this.Controls.Add(this.lblVrijednost);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblVrijednost;
        private System.Windows.Forms.TextBox txtBoxVrijednost;
    }
}

