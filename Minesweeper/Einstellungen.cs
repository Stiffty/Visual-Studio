using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
         
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Program.bomben =trackBar1.Value;
            label5.Text = (trackBar1.Value).ToString();

        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Program.grigsize = trackBar2.Value;
            label6.Text = (trackBar2.Value).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
