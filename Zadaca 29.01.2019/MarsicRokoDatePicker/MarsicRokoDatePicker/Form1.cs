using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsicRokoDatePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            txtBoxA.Clear();
            DateTime datum1 = datePicker.Value;
            DateTime vrijeme1 = datePicker.Value;
            string ispis = "Vaš datum leta je:" + System.Environment.NewLine + datePicker.Value.ToShortDateString() + System.Environment.NewLine + "Vaše vrijeme polaska je:" + System.Environment.NewLine + timePicker.Value.ToShortTimeString();
            txtBoxA.Text = ispis;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
