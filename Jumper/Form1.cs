using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumper
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender,EventArgs e)
        {
            
            int x = 730;
            int y = 300;
            while (true)
            {
                if (x == 0)
                {
                    x = 800;
                }
                else
                {
                    x-=10;
                }
                panel3.Location = new System.Drawing.Point(x,y);
                wait(1);
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

        private void Form1_KeyDown(object sender,KeyEventArgs e)
        {
            int x = 124;
            int y = 260;
            if (e.KeyCode == Keys.A)
            {
                y -=30;
                panel2.Location = new System.Drawing.Point(x,y);
               wait(1000);

                y += 30;
                panel2.Location = new System.Drawing.Point(x,y);
            }
        }
    }
}
