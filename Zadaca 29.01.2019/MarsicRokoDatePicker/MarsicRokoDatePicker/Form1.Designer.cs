namespace MarsicRokoDatePicker
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
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(22, 168);
            this.txtBoxA.Multiline = true;
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(341, 167);
            this.txtBoxA.TabIndex = 0;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(154, 362);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(28, 57);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(94, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Upišite datum leta:";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(28, 104);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(118, 13);
            this.lblVrijeme.TabIndex = 3;
            this.lblVrijeme.Text = "Upišite vrijeme polaska:";
            // 
            // datePicker
            // 
            this.datePicker.AllowDrop = true;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(148, 57);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 4;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(148, 104);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(200, 20);
            this.timePicker.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "Info";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 412);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
    }
}

