using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsicRokoMonthCalendarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOdabir_Click(object sender, EventArgs e)
        {
            TimeSpan ts = mntCal1.SelectionEnd - mntCal1.SelectionStart;
            if (ts.Days<1)
            {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");
            }
            else
            {
                MessageBox.Show("Rezervirali ste usluge u trajanju od " + ts.Days.ToString() + " dana.", "Rezervacija");
            }
        }

        
    }
}
