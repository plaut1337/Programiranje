namespace MarsicRokoMonthCalendarKontrola
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
            this.mntCal1 = new System.Windows.Forms.MonthCalendar();
            this.btnOdabir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mntCal1
            // 
            this.mntCal1.Location = new System.Drawing.Point(41, 31);
            this.mntCal1.MaxSelectionCount = 99;
            this.mntCal1.Name = "mntCal1";
            this.mntCal1.TabIndex = 0;
            // 
            // btnOdabir
            // 
            this.btnOdabir.Location = new System.Drawing.Point(110, 205);
            this.btnOdabir.Name = "btnOdabir";
            this.btnOdabir.Size = new System.Drawing.Size(92, 23);
            this.btnOdabir.TabIndex = 1;
            this.btnOdabir.Text = "Odaberite termin";
            this.btnOdabir.UseVisualStyleBackColor = true;
            this.btnOdabir.Click += new System.EventHandler(this.btnOdabir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 244);
            this.Controls.Add(this.btnOdabir);
            this.Controls.Add(this.mntCal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mntCal1;
        private System.Windows.Forms.Button btnOdabir;
    }
}

