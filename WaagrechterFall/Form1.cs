using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaagrechterFall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e)
        {
            int x = 0;
            int y = 0;
            int v = int.Parse(textBox1.Text);
            int g = 10;
            int t = 0;

            while (true)
            {
                x = (v * t);
                y = (( g + (t * t))/2);
                panel1.Location = new System.Drawing.Point(x,y);
                t++;
                wait(100);
            }
        }

        public static void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if ( milliseconds == 0 || milliseconds < 0 )
            {
                return;
            }

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s,e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while ( timer1.Enabled )
            {
                Application.DoEvents();
            }
        }
    }
}
